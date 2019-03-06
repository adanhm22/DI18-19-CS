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
        private static GestionCarreras SINGELTON { get; set; }

        public static GestionCarreras getSingelton()
        {
            if (SINGELTON==null)
                SINGELTON=new GestionCarreras();
            return SINGELTON;
        }

        private GestionCarreras()
        {
            this.Carreras = new ObservableCollection<Carrera>();
        }

        public void aniadirCarreras()
        {
            for (int i = 0; i < 4; i++)
            {
                this.Carreras.Add(new Carrera("carrera" + i));
            }
        }


    }
}
