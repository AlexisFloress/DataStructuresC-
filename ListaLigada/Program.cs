using ListaLigada;

internal class Program
{
    private static void Main(string[] args)
    {
        CListaLigada miLista = new CListaLigada();

        miLista.Adicionar(1);
        miLista.Adicionar(2);
        miLista.Adicionar(3);
        miLista.Adicionar(4);
        miLista.Adicionar(5);
        miLista.Adicionar(6);


        miLista.Transversa();
        //miLista.Vaciar();
        //miLista.Transversa();

        //Console.WriteLine(miLista.BuscarIndice(1));

        miLista.Insertar(13, 7);
        miLista.Transversa();

    }
}