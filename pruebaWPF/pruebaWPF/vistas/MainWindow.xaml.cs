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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pruebaWPF
{
    
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GestionCarreras Gestion { get; set; }
        public ObservableCollection<Material> Materiales { get; set; }
        public Persona Persona { get; set; }
        public Carrera Carrera { get; set; }
        public int Indice { get; set; }
        public MainWindow(GestionCarreras gestion)
        {
            
            this.Materiales = new ObservableCollection<Material>();
            this.Carrera = new Carrera();
            this.Persona = new Persona();
            this.Carrera.Materiales = this.Materiales;
            this.Carrera.PersonaContacto = this.Persona;
            this.Gestion = gestion;
            
            InitializeComponent();
            this.DataContext = this;
            
        }

        public MainWindow(GestionCarreras gestion,Carrera carreraActual, int indice)
        {
            this.Gestion = gestion;
            this.Carrera = carreraActual;
            this.Materiales = this.Carrera.Materiales;
            this.Persona = this.Carrera.PersonaContacto;
            this.Indice = indice;
            
            InitializeComponent();
            this.botonAniadir.Content = "Modificar";
            this.DataContext = this;
        }



        private void botonMaterial_Click(object sender, RoutedEventArgs e)
        {

            MaterialDisponible m = new MaterialDisponible(this.Gestion);
            m.ShowDialog();
        }

        private void aniadirModificar(object sender, RoutedEventArgs e)
        {
            if (this.Indice != -1)
            {
                this.Gestion.Carreras.RemoveAt(Indice);
                this.Gestion.Carreras.Insert(Indice, this.Carrera);
            }
            else
            {
                this.Gestion.Carreras.Add(this.Carrera);
            }
            this.Close();
        }

        
    }
}
