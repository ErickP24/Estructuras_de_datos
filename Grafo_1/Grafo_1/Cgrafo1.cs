using System;
using System.Collections.Generic;
using System.Text;

namespace Grafo_1
{
    class Cgrafo1
    {
        //Matrpiz de adyacencias entre las aristas
        int[,] Adyacencia;
        //Arreglo que va a guardar el indegree de cada uno de los nodos
        int[] indegree;
        //Va a decir la cantidad de nodos que tiene el grafo
        int nodos;
        //pNodos es un valor que se ingresa indicando la cantidad de nodos que va a tener el grafo
        public Cgrafo1(int pNodos)
        {
            //Asignamos la cantidad de nodos que se desean a la variable nodos
            nodos = pNodos;
            //Se instancia la matriz de adyacencias
            //Como es cuadrada la matriz de adyacencia tiene la forma (nodos,nodos)
            Adyacencia = new int[nodos, nodos];
            //Se instancia el arreglo indegree
            indegree = new int[nodos];
        }
        //Como el grafo es dirigido hay que indicar de donde viene y a donde va 
        //Por lo anterior se declaran pNodoInicio y pNodoFinal
        public void AdicionarArista (int pNodoInicio, int pNodoFinal)
        {
            //En las coordenadas pNodoInicio y pNodoFinal se igualan a 1 para indicar que hay una arista
            Adyacencia[pNodoInicio, pNodoFinal] = 1;
        }
        //Método que va a mostrar las adyacencias
        public void MuestraAdyacencia()
        {
            int n = 0;
            int m = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (n = 0; n < nodos; n++)
            {
                Console.Write("\t{0}", n);
            }
            Console.WriteLine();
            for(n = 0; n < nodos; n++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(n);
                for (m = 0; m < nodos; m++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
        }
    }
}
