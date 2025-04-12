using BurbleSort;

internal class Program
{
    static CListaLigada miLista = new CListaLigada();

    private static void Main(string[] args)
    {

    }

    public static void Swap(int i1, int i2)
    {
        int temp = miLista[i1];
        miLista[i1] = miLista[i2];
        miLista[i2] = temp;
    }
}