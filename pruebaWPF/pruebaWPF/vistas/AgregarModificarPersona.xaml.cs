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
    /// Lógica de interacción para AgregarModificarPersona.xaml
    /// </summary>
    public partial class AgregarModificarPersona : Window
    {
        public Persona Persona { get; set; }
        private int index = -1;
        public AgregarModificarPersona()
        {
            this.Persona = new Persona();
            InitializeComponent();
            this.DataContext = this;
        }

        public AgregarModificarPersona(Persona persona,int index)
        {
            this.Persona = persona;
            this.index = index;
            InitializeComponent();
            this.DataContext = this;
            this.botonAgregarModificar.Content = "Modificar";
        }
        private void BotonAgregarModificar_Click(object sender, RoutedEventArgs e)
        {
            if (index != -1)
            {
                GestionPersonas.getSingelton().Personas.RemoveAt(index);
                GestionPersonas.getSingelton().Personas.Insert(this.index, this.Persona);
            }
            else
                GestionPersonas.getSingelton().Personas.Add(this.Persona);
            this.Close();
        }
    }
}
