using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaWPF
{
    public class Persona
    {
        public String Nombre { get; set; }
        public int Telefono { get; set; }
        public Persona(String nombre, int telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }
        public override string ToString()
        {
            return Nombre + " " + Telefono;
        }
    }
}
