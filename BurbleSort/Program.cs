using ListaLigada;
using System.Transactions;

internal class Program
{
    
    static CListaLigada miLista = new CListaLigada();

    private static void Main(string[] args)
    {
        miLista.Adicionar(12);
        miLista.Adicionar(1);
        miLista.Adicionar(7);
        miLista.Adicionar(11);
        miLista.Adicionar(31);
        miLista.Adicionar(21);
        miLista.Adicionar(13);
        miLista.Adicionar(19);
        miLista.Adicionar(14);
        miLista.Adicionar(29);

        miLista.Transversa();

        int m = 0;
        int n = 0;
        int iteraciones = 0;
        int cantidad = miLista.cantidad();

        for( m = 1; m < cantidad; m++)
        {
            for( n = 0; n < cantidad - m; n++)
            {
                if (miLista[n] > miLista[n + 1])
                {
                    Swap(n, n+1);
                }
                iteraciones++;
            }
        }
        miLista.Transversa();
        Console.WriteLine(iteraciones);

    }

    public static void Swap(int i1, int i2)
    {
        int temp = miLista[i1];
        miLista[i1] = miLista[i2];
        miLista[i2] = temp;
    }
}