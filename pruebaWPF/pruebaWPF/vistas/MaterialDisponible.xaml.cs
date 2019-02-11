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
    /// Lógica de interacción para MaterialDisponible.xaml
    /// </summary>
    public partial class MaterialDisponible : Window
    {
        public ObservableCollection<Material> Materiales { get; set; }
        public Material Material { get; set; }
        public MaterialDisponible(ObservableCollection<Material> Materiales)
        {
            Material = new Material("", 0f, "comida");
            this.Materiales = Materiales;
            InitializeComponent();
            this.DataContext = this;
            
        }

        private void botonAgregar_Click(object sender, RoutedEventArgs e)
        {
            this.Materiales.Add(Material);
            
            this.Close();
        }

        private void combo_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.Material.TipoProducto=(String) this.combo.SelectedItem;
        }
    }
}
