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
    /// Lógica de interacción para aniadirMaterial.xaml
    /// </summary>
    public partial class AniadirMaterial : Window
    {
        public Material Material { get; set; }
        public GestionCarreras Gestion { get; set; }
        public List<string> TiposMateriales { get; set; }
        public AniadirMaterial(GestionCarreras gestion)
        {
            this.Material = new Material();
            this.Gestion = gestion;
            this.TiposMateriales = new List<string>();
            this.TiposMateriales.Add("comida");
            this.TiposMateriales.Add("bebida");
            this.TiposMateriales.Add("material sanitario");
            InitializeComponent();
            DataContext=this;
        }

        private void botonAniadirModificar_Click(object sender, RoutedEventArgs e)
        {
            this.Gestion.Materiales.Add(Material);
            this.Close();
        }
    }
}
