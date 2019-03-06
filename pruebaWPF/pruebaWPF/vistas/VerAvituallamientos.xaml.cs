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
    /// Lógica de interacción para VerAvituallamientos.xaml
    /// </summary>
    public partial class VerAvituallamientos : Window
    {
        public Carrera Carrera { get; set; }
        public ObservableCollection<Avituallamiento> Avituallamientos { get; set; }
        public VerAvituallamientos(Carrera carrera)
        {
            this.Carrera = carrera;
            this.Avituallamientos = GestionAvituallamiento.getSingelon().AvituallamientosDisponibles;
            InitializeComponent();
            DataContext = this;
        }

        private void BotonAgregar_Click(object sender, RoutedEventArgs e)
        {
            Avituallamiento avituallamientoSeleccionado = this.gridAvituallamiento.SelectedItem as Avituallamiento;
            this.Carrera.Avituallamientos.Add(avituallamientoSeleccionado);
            this.Avituallamientos.Remove(avituallamientoSeleccionado);
            this.Close();
        }

        private void DataGrid_GotMouseCapture(object sender, MouseEventArgs e)
        {
            this.botonAgregar.IsEnabled = true;
        }
    }
}
