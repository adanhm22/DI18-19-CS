using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaWPF
{
    public class Carrera : INotifyPropertyChanged
    {
       
        public Carrera()
        {
            // TODO: Complete member initialization
            Materiales = new ObservableCollection<Material>();
            this.PersonaContacto = new Persona();
            this.nombre = "";
            this.puntoKilometrico = 0;

        }

        public Carrera(String nombreCarrera, int puntoKM)
        {
            this.nombre = nombreCarrera;
            this.puntoKilometrico = puntoKM;
            this.Materiales = new ObservableCollection<Material>();
            this.PersonaContacto = new Persona();
        }

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
        private int puntoKilometrico; 
        public int PuntoKilometrico 
        {
            get
            {
                return this.puntoKilometrico;
            }
            set 
            {
                this.puntoKilometrico = value;
                
                this.PropertyChanged(this, new PropertyChangedEventArgs("PuntoKilometrico"));
            } 
        }
        public Persona PersonaContacto { get; set; }
        public ObservableCollection<Material> Materiales{ get; set; }
      

        

        public override string ToString()
        {
            return Nombre;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
    }
}
