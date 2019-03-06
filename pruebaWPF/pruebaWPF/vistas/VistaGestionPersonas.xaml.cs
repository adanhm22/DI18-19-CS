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
    /// Lógica de interacción para VistaGestionPersonas.xaml
    /// </summary>
    public partial class VistaGestionPersonas : Window
    {
        public ObservableCollection<Persona> Personas { get; set; }
        public VistaGestionPersonas()
        {
            this.Personas = GestionPersonas.getSingelton().Personas;
            InitializeComponent();
            DataContext = this;
        }

        private void DataGrid_GotMouseCapture(object sender, MouseEventArgs e)
        {
            this.botonEliminar.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new AgregarModificarPersona().ShowDialog();
        }

        private void BotonEliminar_Click(object sender, RoutedEventArgs e)
        {
            this.botonEliminar.IsEnabled = false;
            this.Personas.Remove(this.gridPersonas.SelectedItem as Persona);
        }

        private void GridPersonas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int index = this.gridPersonas.SelectedIndex;
            new AgregarModificarPersona(this.Personas[index].Clone() as Persona, index).ShowDialog();
        }
    }
}
