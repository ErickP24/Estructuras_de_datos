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
            Cgrafo1 miGrafo = new Cgrafo1(4);
            //Se asignan las aristas del grafo
            miGrafo.AdicionarArista(0, 3);
            miGrafo.AdicionarArista(0, 2);
            miGrafo.AdicionarArista(1, 0);
            miGrafo.AdicionarArista(1, 3);
            miGrafo.AdicionarArista(1, 2);
            miGrafo.AdicionarArista(2, 1);
            miGrafo.AdicionarArista(2, 3);
            miGrafo.AdicionarArista(3, 0);
            miGrafo.AdicionarArista(3, 1);
            miGrafo.AdicionarArista(3, 2);

            //Se llama la funcion que muestra la matriz de adyacencia
            miGrafo.MuestraAdyacencia();

            //Se llama la función para calcular el Indegree
            miGrafo.CalcularIndegree();
            //Se llama la función para mostrar el Indegree
            //lo muestra sobre las columnas de la matriz
            miGrafo.MostrarIndegree();
        }
    }
}
