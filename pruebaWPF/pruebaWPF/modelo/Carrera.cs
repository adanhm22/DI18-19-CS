using pruebaWPF.modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaWPF
{
    public class Carrera : INotifyPropertyChanged,ICloneable
    {

        public Carrera()
        {
            // TODO: Complete member initialization
            this.nombre = "";
            this.Avituallamientos = new ObservableCollection<Avituallamiento>();
        }
        public Carrera(string nombre)
        {
            Nombre = nombre;
            this.Avituallamientos = new ObservableCollection<Avituallamiento>();
        }

        public ObservableCollection<Avituallamiento> Avituallamientos { get; set; }
        private String nombre;
        public String Nombre
        {
            get
            {
                return nombre;
            }
            set {
                this.nombre = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
                }
        }
      

        

        public override string ToString()
        {
            return Nombre;
        }

        
        
        public event PropertyChangedEventHandler PropertyChanged;


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
