using ListaLigada;
using System.Diagnostics;
using System.Net.NetworkInformation;

internal class Program
{
     private static CListaLigada miLista = new CListaLigada();
    private static void Main(string[] args)
    {
        miLista.Adicionar(5);
        miLista.Adicionar(15);
        miLista.Adicionar(9);
        miLista.Adicionar(4);
        miLista.Adicionar(17);
        miLista.Adicionar(2);
        miLista.Adicionar(16);

        miLista.Transversa();

        int cantidad = miLista.cantidad();
        int i = 0;
        int posAgujero = 0;
        int dato = 0;

        for(i = 1; i<cantidad; i++)
        {
            dato = miLista[i];
            posAgujero = i;

            while (posAgujero > 0 && miLista[posAgujero - 1 ] > dato)
            {
                Console.WriteLine("-----------");
                Console.Write(miLista[posAgujero]+" ");
                miLista[posAgujero] = miLista[posAgujero - 1];
                Console.WriteLine("indice {0}, Dato{1}",posAgujero, miLista[posAgujero]);
                
                posAgujero--;
            }
            miLista[posAgujero] = dato; 

        }
        miLista.Transversa();

    }
}