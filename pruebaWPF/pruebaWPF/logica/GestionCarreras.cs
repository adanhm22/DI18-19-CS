using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaWPF.logica
{

    public class GestionCarreras
    {
        public ObservableCollection<Carrera> Carreras { get; set; }
        public ObservableCollection<Material> Materiales { get; set; }

        public GestionCarreras()
        {
            this.Carreras = new ObservableCollection<Carrera>();
            this.Materiales = new ObservableCollection<Material>();
        }

        public void aniadirCarreras()
        {
            for (int i = 0; i < 4; i++)
            {
                this.Carreras.Add(new Carrera("carrera" + i, i));
            }
        }


    }
}
