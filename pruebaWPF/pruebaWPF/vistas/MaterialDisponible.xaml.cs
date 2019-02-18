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

namespace pruebaWPF
{
    /// <summary>
    /// Lógica de interacción para MaterialDisponible.xaml
    /// </summary>
    public partial class MaterialDisponible : Window
    {
        public GestionCarreras Gestion { get; set; }

        public MaterialDisponible(GestionCarreras gestion)
        {
            this.Gestion = gestion;
            InitializeComponent();
            DataContext = Gestion;
        }
    }
}
