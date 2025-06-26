using ListaLigada;
using System.Net.NetworkInformation;
using System.Xml.Serialization;

internal class Program
{
    
    public static CListaLigada miLista = new CListaLigada();

    private static void Main(string[] args)
    {
        miLista.Adicionar(2);
        miLista.Adicionar(5);
        miLista.Adicionar(8);
        miLista.Adicionar(1);
        miLista.Adicionar(14);
        miLista.Adicionar(3);
        miLista.Adicionar(11);
        miLista.Adicionar(9);

        miLista.Transversa();
        int indiceFinal = miLista.cantidad() - 1;

        QuickSort(0, indiceFinal);

        miLista.Transversa();



    }
    //Metodo que nos ayuda a intercambiar 2 elementos
    public static void Swap(int i1, int i2)
    {
        int temp = miLista[i1];
        miLista[i1] = miLista[i2];
        miLista[i2] = temp;
    }
    public static int Particion(int pInicio, int pFinal)
    {
        int pivote = 0;
        int iPivote = 0;
        int n = 0;

        //Se selecciona el ultimo elemento de la lista como pivote
        pivote = miLista[pFinal];

        //Se colocal el indice del pivote con el indice del inicio
        iPivote = pInicio;
        
        //Recorremos la lista en le fragmento indicado
        for(n = pInicio; n < pFinal; n++)
        {
            if(miLista[n] <= pivote)
            {
                Swap(n, iPivote);
                iPivote++;
            }
        }
        //hacemos el ultimo intercambio entre el pivote
        Swap(iPivote, pFinal);

        return iPivote;

    } 
    public static void QuickSort(int pInicio, int pFinal)
    {
        int iPivote = 0;

        //caso base, un elemento o fragmento invalido
        if(pInicio >= pFinal)
            return;

        //obtenemos el indice del pivote para el fragmento con el que trbajamos 
        iPivote = Particion(pInicio, pFinal);

        //casos inductivos
        QuickSort(pInicio, iPivote-1);
        QuickSort(iPivote+1, pInicio); 
    }
}