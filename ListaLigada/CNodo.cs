using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada
{
    internal class CNodo
    {
        //Informacion del nodo
        private int dato;

        //Referencia al sigueinte Nodo
        private CNodo siguiente = null;

        public int Dato { get => dato; set => dato = value; }
        internal CNodo Siguiente { get => siguiente; set => siguiente = value; }

        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
