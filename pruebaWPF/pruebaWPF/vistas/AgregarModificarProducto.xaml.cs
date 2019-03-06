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
    /// Lógica de interacción para AgregarModificarProducto.xaml
    /// </summary>
    public partial class AgregarModificarProducto : Window
    {
        private int index = -1;
        public AgregarModificarProducto()
        {
            this.Material = new Material();
            this.inicializar();
            this.ComboTipos.SelectedItem = "bebida";
        }

        public AgregarModificarProducto(Material material,int index)
        {
            this.Material = material;
            this.inicializar();
            this.ComboTipos.SelectedItem = material.TipoProducto;
            this.index = index;
            this.botonAgregarModificar.Content = "Modificar";
        }
        public Material Material { get; set; }
        public String[] TiposMaterial { get; set; }

        public void inicializar()
        {
            TiposMaterial = new string[] { "bebida", "comida", "material sanitario" };
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Material.TipoProducto = (String)ComboTipos.SelectedItem;
            if (index != -1)
            {
                Material material = GestionProductos.getSingelton().Materiales[index];
                GestionProductos.getSingelton().Materiales.Remove(material);
                GestionProductos.getSingelton().Materiales.Insert(this.index, this.Material);

                GestionProductos.getSingelton().MaterialesDisponibles.Remove(material);
                GestionProductos.getSingelton().MaterialesDisponibles.Insert(this.index, this.Material);
            }
            else
            {
                GestionProductos.getSingelton().addMaterial(this.Material);
            }
            this.Close();
        }
    }
}
