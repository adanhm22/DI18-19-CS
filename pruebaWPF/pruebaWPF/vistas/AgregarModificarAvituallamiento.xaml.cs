using pruebaWPF.logica;
using pruebaWPF.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace pruebaWPF.vistas
{
    /// <summary>
    /// Lógica de interacción para AgregarModificarAvituallamiento.xaml
    /// </summary>
    public partial class AgregarModificarAvituallamiento : Window
    {
        public Avituallamiento Avituallamiento { get; set; }
        private int index = -1;
        public AgregarModificarAvituallamiento()
        {
            this.Avituallamiento = new Avituallamiento();
            inicializar();
        }

        public AgregarModificarAvituallamiento(Avituallamiento avituallamiento, int index)
        {
            this.Avituallamiento = avituallamiento;
            this.index = index;
            inicializar();
            int indexCarrera =GestionCarreras.getSingelton().Carreras.IndexOf(avituallamiento.Carrera);
            this.comboCarreras.SelectedIndex = indexCarrera;

            int indexPersona = GestionPersonas.getSingelton().Personas.IndexOf(avituallamiento.PersonaContacto);
            this.comboPersonas.SelectedIndex = indexPersona;
            this.botonAgregarModificar.Content = "Modificar";
        }

        private void inicializar()
        {
            InitializeComponent();
            DataContext=this;
            this.comboCarreras.DataContext = GestionCarreras.getSingelton();
            this.gridMateriales.DataContext = this;
            this.comboPersonas.DataContext = GestionPersonas.getSingelton();
        }

        private void BotonNuevoMaterial_Click(object sender, RoutedEventArgs e)
        {
            new AgregarModificarProducto().ShowDialog();
        }

        private void BotonNuevaCarrera_Click(object sender, RoutedEventArgs e)
        {
            new AgregarModificarCarrera().ShowDialog();
        }

        private void BotonNuevaPersona_Click(object sender, RoutedEventArgs e)
        {
            new AgregarModificarPersona().ShowDialog();
        }

        private void BotonAgregarModificar_Click(object sender, RoutedEventArgs e)
        {
            this.Avituallamiento.PersonaContacto = this.comboPersonas.SelectedItem as Persona;
            this.Avituallamiento.Carrera = this.comboCarreras.SelectedItem as Carrera;
            if (index != -1)
            {
                GestionAvituallamiento gestion = GestionAvituallamiento.getSingelon();
                Avituallamiento avituallamientoSeleccionado = gestion.Avituallamientos[index];
                gestion.Avituallamientos.Remove(avituallamientoSeleccionado);
                gestion.Avituallamientos.Insert(index, this.Avituallamiento);

                gestion.AvituallamientosDisponibles.Remove(avituallamientoSeleccionado);
                gestion.AvituallamientosDisponibles.Insert(index, this.Avituallamiento);

                this.Avituallamiento.Carrera.Avituallamientos.Remove(this.Avituallamiento);
                this.Avituallamiento.Carrera.Avituallamientos.Add(this.Avituallamiento);
            }
            else
            {
                GestionAvituallamiento.getSingelon().addAvituallamiento(this.Avituallamiento);
                this.Avituallamiento.Carrera.Avituallamientos.Remove(this.Avituallamiento);
                this.Avituallamiento.Carrera.Avituallamientos.Add(this.Avituallamiento);
            }
            this.Close();
        }

        private void BotonAgregarMaterial_Click(object sender, RoutedEventArgs e)
        {
            new VerMateriales(this.Avituallamiento).ShowDialog();
        }

        private void DataGrid_GotMouseCapture(object sender, MouseEventArgs e)
        {
            this.botonEliminarMaterial.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Material materialSeleccionado = this.gridMateriales.SelectedItem as Material;
            this.Avituallamiento.MaterialDisponible.Remove(materialSeleccionado);
            GestionProductos.getSingelton().MaterialesDisponibles.Add(materialSeleccionado);
            this.botonEliminarMaterial.IsEnabled = false;
        }
    }
}
