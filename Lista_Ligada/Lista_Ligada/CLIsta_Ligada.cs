using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_Ligada
{
    class CLIsta_Ligada
    {
        //Es el ancla o encabezado de la lista
        //Es necesario porque indica el inicio de la lista ligada
        //Puede guardar datos (es a gusto del consumidor)
        private CNodo ancla;
        //Esta variable de referencia que nos ayuda a trabajar con la lista 
        //Se usa para referenciarse a diferentes nodos dentor de la lista
        //Para indicar el nodo en el que se está trabajando en el momento
        private CNodo trabajo;
        //Esta variable de referencia apoya en ciertas operaciones de la lista 
        //Se usa para referenciarse a diferentes nodos dentor de la lista
        //Va a apoyar en ciertas operaciones como busqueda o saber cual es el nodo anterior
        private CNodo trabajo2;

        public CLIsta_Ligada()
        {
            //Instaciamos el ancla
            //Creamos el ancla 
            ancla = new CNodo();
            //Como es una lista vacia su siguiente es null
            //Como se está creando hasta ahora ancla no tiene conexión con nadie
            ancla.Siguiente = null;
        }

        //Método para recorrer la lista
        public void Transversa()
        {
            //Trabajo la asigno al inicio(ancla)
            //Trabajo es quien se va a referencia nodo a nodo y va a estar al inicio de la lista
            trabajo = ancla;

            //Se recorre la lista hasta llegar al final, es decir hasta encontrar NULL
            while (trabajo.Siguiente != null)
            {
                //Trabajoo comienza a avanzar
                //Nos movemos al siguiente nodo
                trabajo = trabajo.Siguiente;
                //Se obitne el dato del nodo y se muestra
                //Obtengo el dato del nodo y lo muestro 
                int nod = trabajo.Dato;
                Console.Write("{0},",nod);
            }
            //Se baja la linea
            Console.WriteLine();
        }

        //Agregar un siguiente elemento
        //El agregar siempre va al final
        public void Adicionar(int pDato)
        {
            //Colocamos trabajo en el incio de la lista
            trabajo = ancla;
            //Se recorre la lista hasta el final
            while(trabajo.Siguiente != null)
            {
                //Trabajo avanza entre los diferentes nodos
                trabajo = trabajo.Siguiente;
            }
            //Se crea un nuevo nodo
            //Aun no esta relacionado
            CNodo temp = new CNodo();
            //Se inserta el datos en el nodo creado
            temp.Dato = pDato;
            //Se finaliza apuntando a null
            temp.Siguiente = null;
            //Ligar el utimo nodo encontrado con el recien creado
            trabajo.Siguiente = temp;
        }

        //Método para vaciar la lista
        public void Vaciar()
        {
            //así lo que se hace es desconectar el ancla de la lista
            //el recolector de C# elimina los nodos que se tienen
            //En otros lenguajes hay que liberar nodo a nodo y liberar la memjoria de manera adecuada
            ancla.Siguiente = null;
        }

        //Indica si la lista está vacia o no
        public bool EstaVacio()
        {
            //Verifica si el ancla esta apuntando a null, de ser así retorna true indicando que si está vacía la lista
            //de lo contrario retorna false lo que hace saber que hay nodos en la lista
            if(ancla.Siguiente == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Reglresa el primer nodo con el valor que se está buscando
        //Si el valor está en varios nodos trae la primera concurrencia
        //Si el nodo no existe va a regresar un null
        //Si si existe trae la referencia a ese lugar
        public CNodo Buscar (int pDato)
        {
            //Se verifica si la lista está vacía y retorna null de ser así
            if(EstaVacio() == true)
            {
                return null;
            }
            //Se hace una variación a la trasversa
            //Trabajo 2 sirve de referencia para el nodo que se está buscando 
            trabajo2 = ancla;
            //Como en la trasversa se recorre la lista para realizar la busqueda del valor ingresado
            while(trabajo2.Siguiente != null)
            {
                trabajo2 = trabajo2.Siguiente;
                //Si, el valor que tiene trabajo2 es igual al solicitado "pDato"
                //Retorna el valor de trabajo2
                if(trabajo2.Dato == pDato)
                {
                    return trabajo2;
                }
            }
            //Si no se encontró el pDato retorna null indicando que no está
            return null;
        }
    }
}
