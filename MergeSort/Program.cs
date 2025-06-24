using ListaLigada;

internal class Program
{
    private static void Main(string[] args)
    {
        CListaLigada miLista = new CListaLigada();
        miLista.Adicionar(3);
        miLista.Adicionar(7);
        miLista.Adicionar(9);
        miLista.Adicionar(4);
        miLista.Adicionar(1);
        miLista.Adicionar(8);

        miLista.Transversa();


        //CListaLigada l = new CListaLigada();
        //l.Adicionar(2);
        //l.Adicionar(9);
        //l.Adicionar(5);
        //l.Adicionar(6);

        //CListaLigada r = new CListaLigada();
        //r.Adicionar(1);
        //r.Adicionar(3);
        //r.Adicionar(7);
        //r.Adicionar(11);

        //CListaLigada merged = Merge(l, r);
        //merged.Transversa();

        CListaLigada ordenada = MergeSort(miLista);
        ordenada.Transversa();

    }


    public static CListaLigada Merge(CListaLigada listaIzq, CListaLigada listaDer)
    {
        CListaLigada unida = new CListaLigada();

        //Inidices
        int indiceI = 0;
        int indiceD = 0;

        //Cantidad de elementos 
        int cantI = listaIzq.cantidad();
        int cantD = listaDer.cantidad();

        while(indiceI<cantI && indiceD < cantD)
        {
            if (listaIzq[indiceI] <= listaDer[indiceD])
            {
                unida.Adicionar(listaIzq[indiceI]);
                indiceI++;
            }
            else
            {
                unida.Adicionar(listaDer[indiceD]);
                indiceD++;
            }
        }
        return unida;
    }
    private static CListaLigada MergeSort(CListaLigada pLista)
    {
        //Cantidad elementos de la lista
        int cantidad = pLista.cantidad();
        int n = 0;

        //Caso base
        if(cantidad < 2)
        {
            return pLista;
        }

        //We get the midddle´s list 
        int mitad = cantidad / 2;
        CListaLigada izquierda = new CListaLigada();
        CListaLigada derecha = new CListaLigada();

        //mitad izquierda
        for(n=0; n <mitad; n++)
        {
            izquierda.Adicionar(pLista[n]);
        }
        for(n = mitad; n < cantidad; n++)
        {
            derecha.Adicionar(pLista[n]);
        }

        //Caso inductivo
        CListaLigada tempI = MergeSort(izquierda);
        CListaLigada tempD = MergeSort(derecha);

        CListaLigada ordenada = Merge(tempI, tempD);

        return ordenada;


    }
}