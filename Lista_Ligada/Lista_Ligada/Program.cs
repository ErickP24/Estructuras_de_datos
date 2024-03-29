﻿using System;

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
            //Se declara una variable tipo CNodo que va a ser igual a la función buscar con un parametro
            //y retorna a encontrado dependiendo su resultado
            CNodo encontrado = miLista.Buscar(15);
            Console.WriteLine(encontrado);
            //Dentro de la impresión se asigna la función y el parametro a encontrar con su indice
            Console.WriteLine(miLista.BuscarIndice(9));
            //Dentro de la impresión se asigna la función y el parametro a encontrar con el nodo anterior al solicitado
            Console.WriteLine(miLista.BuscarAnterior(9));
            //Desocupa la lista y luego inserna un nuevo nodo
            miLista.Vaciar();
            miLista.Adicionar(15);
            miLista.Transversa();
            //Retorna false indicando que hay un nodo, ya que el ancla no apunta a null
            Console.WriteLine(miLista.EstaVacio());
            //Desocupa la lista
            miLista.Vaciar();
            miLista.Transversa();
            //Retorna true indicando que no hay un nodo, ya que el ancla apunta a null
            Console.WriteLine(miLista.EstaVacio());
            //Inserta diferentes nodos con su respectivo valor
            miLista.Adicionar(3);
            miLista.Adicionar(5);
            miLista.Adicionar(7);
            miLista.Adicionar(9);
            miLista.Adicionar(11);
            miLista.Adicionar(15);
            //Recorre y muestra los objetos de la lista
            miLista.Transversa();
            //Borra el nodo que contiene el valor 9
            miLista.Borrar(9);
            //Recorre y muestra los objetos de la lista
            miLista.Transversa();
            //Inserta un nodo que contiene a 2 y que será insertado después del nodo que contiene a 15
            miLista.Insertar(15,2);
            //Inserta un nodo después del ancla que contiene un valor
            miLista.InsertarAlInicio(9455);
            miLista.Transversa();
        }
    }
}
