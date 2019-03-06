using pruebaWPF.modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaWPF.logica
{
    public class GestionAvituallamiento
    {
        public ObservableCollection<Avituallamiento> Avituallamientos { get; set; }
        public ObservableCollection<Avituallamiento> AvituallamientosDisponibles { get; set; }
        private static GestionAvituallamiento SINGELTON;

        public static GestionAvituallamiento getSingelon()
        {
            if (SINGELTON == null)
                SINGELTON = new GestionAvituallamiento();
            return SINGELTON;
        }

        private GestionAvituallamiento()
        {
            this.Avituallamientos = new ObservableCollection<Avituallamiento>();
            this.AvituallamientosDisponibles = new ObservableCollection<Avituallamiento>();
        }

        public void addAvituallamiento(Avituallamiento nuevo)
        {
            this.Avituallamientos.Add(nuevo);
            this.AvituallamientosDisponibles.Add(nuevo);
        }


    }
}
