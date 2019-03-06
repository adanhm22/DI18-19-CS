using pruebaWPF.logica;
using pruebaWPF.modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para VerMateriales.xaml
    /// </summary>
    public partial class VerMateriales : Window
    {
        public Avituallamiento  Avituallamiento { get; set; }
        public ObservableCollection<Material> Materiales { get; set; }
        public VerMateriales(Avituallamiento avituallamiento)
        {
            this.Materiales = GestionProductos.getSingelton().MaterialesDisponibles;
            this.Avituallamiento = avituallamiento;
            InitializeComponent();
            DataContext = this;
        }

        private void BotonAgregar_Click(object sender, RoutedEventArgs e)
        {
            GestionProductos gestion =GestionProductos.getSingelton();
            Material materialSeleccionado = this.gridMateriales.SelectedItem as Material;
            gestion.MaterialesDisponibles.Remove(materialSeleccionado);
            this.Avituallamiento.MaterialDisponible.Add(materialSeleccionado);
            this.Close();
        }

        private void GridMateriales_GotMouseCapture(object sender, MouseEventArgs e)
        {
            this.botonAgregar.IsEnabled = true;
        }
    }
}
