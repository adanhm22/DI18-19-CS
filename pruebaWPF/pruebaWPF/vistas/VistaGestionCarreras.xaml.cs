using pruebaWPF.logica;
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
    /// Lógica de interacción para VistaGestionCarreras.xaml
    /// </summary>
    public partial class VistaGestionCarreras : Window
    {
        public ObservableCollection<Carrera> Carreras { get; set; } 
        public VistaGestionCarreras()
        {
            this.Carreras = GestionCarreras.getSingelton().Carreras;
            InitializeComponent();
            DataContext = this;
        }

        private void BotonEliminar_Click(object sender, RoutedEventArgs e)
        {
            this.botonEliminar.IsEnabled = false;
            this.Carreras.RemoveAt(this.gridCarreras.SelectedIndex);
        }

        private void BotonNueva_Click(object sender, RoutedEventArgs e)
        {
            new AgregarModificarCarrera().ShowDialog();
        }

        private void DataGrid_GotMouseCapture(object sender, MouseEventArgs e)
        {
            this.botonEliminar.IsEnabled = true;
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int index = this.gridCarreras.SelectedIndex;
            new AgregarModificarCarrera(this.Carreras[index].Clone() as Carrera, index).ShowDialog();
        }
    }
}
