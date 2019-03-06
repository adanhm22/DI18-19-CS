using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaWPF
{
    public class Persona : INotifyPropertyChanged,ICloneable
    {
        public Persona()
        {
            // TODO: Complete member initialization
        }
        public Persona(String nombre, int telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private string nombre;
        public String Nombre 
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
            }
        }
        private int telefono;
        public int Telefono 
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Telefono"));
            }
        }
        
       
        public override string ToString()
        {
            return Nombre + " " + Telefono;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
