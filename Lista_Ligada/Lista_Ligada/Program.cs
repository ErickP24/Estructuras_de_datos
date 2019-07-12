using System;

namespace Lista_Ligada
{
    class Program
    {
        static void Main(string[] args)
        {
            //La lista es "una evolución del arreglo", es decir que es dinámica y cambia su tamaño según la necesidad
            //Se compone de nodos que están conectados entre si
            //Nodo: es un elemento desde el cual se contruye la lista, guarda uno o varios datos en su interior
            //tiene referencia a uno o varios nodos

            //Crea miLista de tipo CLista_Ligada
            CLIsta_Ligada miLista = new CLIsta_Ligada();

            //Inserta diferentes nodos con su respectivo valor
            miLista.Adicionar(3);
            miLista.Adicionar(5);
            miLista.Adicionar(7);
            miLista.Adicionar(9);
            miLista.Adicionar(11);
            miLista.Adicionar(15);
            //Recorre y muestra los objetos de la lista
            miLista.Transversa();
        }
    }
}
