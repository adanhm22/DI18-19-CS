using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaWPF
{
    public class Material : 
    {
        private String nombre;
        private float precio;
        private String tipoProducto;

        public String Nombre { get; set; }
        public float Precio {get;set;}
        public String TipoProducto{get;set;}
        


        public Material(String nombre, float precio, String tipo)
        {
            Nombre = nombre;
            Precio = precio;
            this.TipoProducto = tipo;
        }

    }
}
