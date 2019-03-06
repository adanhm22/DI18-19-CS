using pruebaWPF.logica;
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
    /// Lógica de interacción para VistaGestionProductos.xaml
    /// </summary>
    public partial class VistaGestionProductos : Window
    {
        public GestionProductos Productos { get; set; }
        public VistaGestionProductos()
        {
            InitializeComponent();
            Productos = GestionProductos.getSingelton();
            DataContext = Productos;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AgregarModificarProducto agregar = new AgregarModificarProducto();
            agregar.ShowDialog();
        }

        private void BotonEliminar_Click(object sender, RoutedEventArgs e)
        {
            this.Productos.Materiales.RemoveAt(GridProductos.SelectedIndex);
            this.botonEliminar.IsEnabled = false;
        }

        private void GridProductos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Material materialSeleccionado = GridProductos.SelectedItem as Material;
            int index = GridProductos.SelectedIndex;
            new AgregarModificarProducto(materialSeleccionado.Clone() as Material,index).ShowDialog();
        }

        private void GridProductos_GotMouseCapture(object sender, MouseEventArgs e)
        {
            int index = GridProductos.SelectedIndex;
            if (index >=0)
            {
                this.botonEliminar.IsEnabled = true;
            }
            else
                this.botonEliminar.IsEnabled = false;
        }
    }
}
