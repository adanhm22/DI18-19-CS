using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaWPF.modelo
{
    public class Avituallamiento : INotifyPropertyChanged,ICloneable
    {
        public Avituallamiento()
        {
            this.Carrera = new Carrera();
            this.MaterialDisponible = new ObservableCollection<Material>();
            this.PersonaContacto = new Persona();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        
        public Carrera Carrera { get; set; }

        private int puntoKilometrico;
        public int PuntoKilometrico {
            get { return this.puntoKilometrico; }
            set
            {
                this.puntoKilometrico = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("PuntoKilometrico"));
            }
        }

        public Persona PersonaContacto { get; set; } 
        
        public ObservableCollection<Material> MaterialDisponible { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
