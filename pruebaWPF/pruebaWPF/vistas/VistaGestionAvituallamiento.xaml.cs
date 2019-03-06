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
    /// Lógica de interacción para VistaGestionAvituallamientoç.xaml
    /// </summary>
    public partial class VistaGestionAvituallamiento : Window
    {
        public ObservableCollection<Avituallamiento> Avituallamientos { get; set; }
        public VistaGestionAvituallamiento()
        {
            InitializeComponent();
            this.Avituallamientos= GestionAvituallamiento.getSingelon().Avituallamientos;
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new AgregarModificarAvituallamiento().ShowDialog();
        }

        private void GridAvituallamientos_GotMouseCapture(object sender, MouseEventArgs e)
        {
            this.botonEliminar.IsEnabled = true;
        }

        private void BotonEliminar_Click(object sender, RoutedEventArgs e)
        {
            int index = this.gridAvituallamientos.SelectedIndex;
            this.Avituallamientos.RemoveAt(index);
            this.botonEliminar.IsEnabled = false;
        }

        private void GridAvituallamientos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int index = this.gridAvituallamientos.SelectedIndex;
            Avituallamiento avituallamiento = this.gridAvituallamientos.SelectedItem as Avituallamiento;
            new AgregarModificarAvituallamiento(avituallamiento.Clone() as Avituallamiento,index).ShowDialog();
        }
    }
}
