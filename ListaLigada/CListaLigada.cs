using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada
{
    public class CListaLigada
    {
        //Indica el incio de la lista Ligada
        private CNodo ancla;

        private CNodo trabajo;
        private CNodo trabajo2;

        public CListaLigada()
        {
            ancla = new CNodo();

            ancla.Siguiente = null;
        }

        public void Transversa()
        {
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                int d = trabajo.Dato;
                Console.Write("{0},", d);
            }
            Console.WriteLine();
        }
        public void Adicionar(int pDato)
        {
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
            }

            CNodo temp = new CNodo();

            temp.Dato = pDato;

            temp.Siguiente = null;

            trabajo.Siguiente = temp;

        }
        public void Vaciar()
        {
            ancla.Siguiente = null;
        }
        public bool EstaVacio()
        {
            if (ancla.Siguiente == null)
                return true;
            else
                return false;
        }
        public CNodo Buscar(int pDato)
        {
            if (EstaVacio())
            {
                return null;
            }

            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;

                if (trabajo.Dato == pDato)
                {
                    return trabajo;
                }
            }
            return null;
        }
        public int BuscarIndice(int pDato)
        {
            int n = -1;

            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                n++;
                if (trabajo.Dato == pDato)
                {
                    return n;
                }
            }
            return -1;
        }
        public CNodo BuscarAnterior(int pDato)
        {
            trabajo = ancla;
            int n = -1;
            while (trabajo.Siguiente != null)
            {
                n++;
                if (trabajo.Siguiente.Dato == pDato && n == 0)
                {
                    return trabajo;
                }
                else if (trabajo.Siguiente.Dato == pDato)
                {
                    return trabajo;
                }

                trabajo = trabajo.Siguiente;
            }
            return trabajo;
        }
        public void Borrar(int pDato)
        {
            if (EstaVacio() == true)
            {
                return;
            }
            CNodo anterior = BuscarAnterior(pDato);
            CNodo encontrar = Buscar(pDato);

            if (encontrar == null)
                return;
            anterior.Siguiente = encontrar.Siguiente;

            encontrar.Siguiente = null;
        }
        public void Insertar(int pDonde, int pDato)
        {
            trabajo = Buscar(pDonde);

            if (trabajo == null)
            {
                return;
            }

            CNodo temp = new CNodo();
            temp.Dato = pDato;

            temp.Siguiente = trabajo.Siguiente;

            trabajo.Siguiente = temp;
        }
        public void InsertarIncio(int pDato)
        {
            CNodo temp = new CNodo();

            temp.Dato = pDato;

            temp.Siguiente = ancla.Siguiente;
            ancla.Siguiente = temp;
        }
        public CNodo ObtenerPorIndice(int pIndice)
        {
            int n = -1;
            trabajo = ancla;

            while (n <= pIndice)
            {
                n++;
                trabajo = trabajo.Siguiente;
                if (n == pIndice)
                {
                    return trabajo;
                }
            }
            return null;
        }

        public int this[int pIndice]
        {
            get
            {
                return ObtenerPorIndice(pIndice).Dato;
            }

            set
            {
                trabajo = ObtenerPorIndice(pIndice);
                if (trabajo != null)
                {
                    trabajo.Dato = value;
                }
            }
        }
        public int cantidad()
        {
            int n = 0;

            trabajo = ancla;

            while(trabajo.Siguiente != null)
            {
                n++;
                trabajo= trabajo.Siguiente;
            }
            return n;
        }
    }
}

