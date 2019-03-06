using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaWPF.logica
{
    public class GestionProductos
    {
        private static GestionProductos SINGELTON;

        public static GestionProductos getSingelton()
        {
            if (SINGELTON == null)
                SINGELTON = new GestionProductos();
            return SINGELTON;
        }
        public ObservableCollection<Material> Materiales { get; set; }
        public ObservableCollection<Material> MaterialesDisponibles { get; set; }

        private GestionProductos()
        {
            this.Materiales = new ObservableCollection<Material>();
            this.MaterialesDisponibles = new ObservableCollection<Material>();
        }

        public void addMaterial(Material nuevo)
        {
            this.Materiales.Add(nuevo);
            this.MaterialesDisponibles.Add(nuevo);
        }


    }
}
