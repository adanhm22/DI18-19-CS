using pruebaWPF.logica;
using pruebaWPF.vistas;
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

namespace pruebaWPF
{
    
    /// <summary>
    /// Lógica de interacción para Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public GestionCarreras Gestion { get; set; }
        public Main()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VistaGestionProductos productos =  new VistaGestionProductos();
            productos.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new VistaGestionAvituallamiento().ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new VistaGestionPersonas().ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            new VistaGestionCarreras().ShowDialog();
        }
    }
}
