using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaWPF.logica
{
    public class GestionPersonas
    {
        private static GestionPersonas SINGELTON;

        public static GestionPersonas getSingelton()
        {
            if (SINGELTON == null)
                SINGELTON = new GestionPersonas();
            return SINGELTON;
        }

        private GestionPersonas()
        {
            this.Personas = new ObservableCollection<Persona>();
        }
        public ObservableCollection<Persona> Personas { get; set; }
    }
}
