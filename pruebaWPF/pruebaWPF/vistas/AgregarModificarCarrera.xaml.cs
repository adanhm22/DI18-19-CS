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
    /// Lógica de interacción para AgregarModificarCarrera.xaml
    /// </summary>
    public partial class AgregarModificarCarrera : Window
    {
        public Carrera Carrera { get; set; }
        private int index=-1;
        public AgregarModificarCarrera()
        {
            this.Carrera = new Carrera();
            InitializeComponent();
            this.DataContext = this;
        }

        public AgregarModificarCarrera(Carrera carrera,int index)
        {
            this.Carrera = carrera;
            this.index = index;
            InitializeComponent();
            this.DataContext = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new VerAvituallamientos(this.Carrera).ShowDialog();
        }

        private void DataGrid_GotMouseCapture(object sender, MouseEventArgs e)
        {
            this.botonEliminarAvituallamiento.IsEnabled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.index != -1)
            {
                GestionCarreras.getSingelton().Carreras.RemoveAt(this.index);
                GestionCarreras.getSingelton().Carreras.Insert(this.index, this.Carrera);
            }
            else
                GestionCarreras.getSingelton().Carreras.Add(this.Carrera);
            
            
            foreach(Avituallamiento avi in this.Carrera.Avituallamientos)
            {
                avi.Carrera = this.Carrera;
            }
            this.Close();
        }

        private void BotonEliminarAvituallamiento_Click(object sender, RoutedEventArgs e)
        {
            this.botonEliminarAvituallamiento.IsEnabled = false;
            Avituallamiento avi=this.gridAvituallamiento.SelectedItem as Avituallamiento;
            avi.Carrera = new Carrera();
            this.Carrera.Avituallamientos.Remove(avi);
        }
    }
}
