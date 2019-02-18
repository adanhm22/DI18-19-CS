using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaWPF
{
    public class Material : INotifyPropertyChanged
    {
       
        private String nombre;
        private float precio;
        private String tipoProducto;
        public event PropertyChangedEventHandler PropertyChanged;

        public Material(String nombre, float precio, String tipo)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.tipoProducto = tipo;
        }

        public Material()
        {
            // TODO: Complete member initialization
        }

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
        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Precio"));
            }
        }
        public String TipoProducto
        {
            get
            {
                return this.tipoProducto;
            }
            set
            {
                this.tipoProducto = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("TipoProducto"));
            }
        }
        


        

        public override string ToString()
        {
            return Nombre + " " + TipoProducto + " " + Precio;
        }
        
    }
}
