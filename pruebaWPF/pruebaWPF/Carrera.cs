using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaWPF
{
    public class Carrera
    {
        public String Nombre { get; set; }
        public int PuntoKilometrico { get; set; }
        public Persona PersonaContacto { get; set; }
        public ObservableCollection<Material> Materiales { get; set; }
        public Carrera(String nombreCarrera, int puntoKM)
        {
            Nombre = nombreCarrera;
            PuntoKilometrico = puntoKM;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
