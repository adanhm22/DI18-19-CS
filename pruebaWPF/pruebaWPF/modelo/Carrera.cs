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
        public event PropertyChangedEventHandler PropertyChanged;
        private String nombre;
        public String Nombre
        {
            get
            {
                return nombre;
            }
            set {
                this.nombre = value;
               // this.PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
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
                
             //   this.PropertyChanged(this, new PropertyChangedEventArgs("PuntoKilometrico"));
            } 
        }
        public Persona PersonaContacto { get; set; }
        public ObservableCollection<Material> Materiales { get; set; }
        public Carrera(String nombreCarrera, int puntoKM)
        {
            Nombre = nombreCarrera;
            PuntoKilometrico = puntoKM;
            Materiales = new ObservableCollection<Material>();
            PersonaContacto = new Persona();
        }

        public Carrera()
        {
            // TODO: Complete member initialization
            Materiales = new ObservableCollection<Material>();
            PersonaContacto=new Persona();
        }

        public override string ToString()
        {
            return Nombre;
        }


        
    }
}
