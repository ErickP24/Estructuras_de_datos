using System;

namespace Grafo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //nodo es una variable que se declara como apoyo para poder resolver el algoritmo mas adelante
            int nodo = 0;
            //Instancio el grafo, es decir que creo un grafo de 7 nodos
            Cgrafo1 miGrafo = new Cgrafo1(7);
            //Se asignan las aristas del grafo
            miGrafo.AdicionarArista(0, 1);
            miGrafo.AdicionarArista(0, 2);
            miGrafo.AdicionarArista(0, 3);
            miGrafo.AdicionarArista(1, 3);
            miGrafo.AdicionarArista(1, 4);
            miGrafo.AdicionarArista(2, 5);
            miGrafo.AdicionarArista(3, 2);
            miGrafo.AdicionarArista(3, 5);
            miGrafo.AdicionarArista(3, 6);
            miGrafo.AdicionarArista(4, 3);
            miGrafo.AdicionarArista(4, 6);
            miGrafo.AdicionarArista(6, 5);

            //Se llama la funcion que muestra la matriz de adyacencia
            miGrafo.MuestraAdyacencia();
        }
    }
}
