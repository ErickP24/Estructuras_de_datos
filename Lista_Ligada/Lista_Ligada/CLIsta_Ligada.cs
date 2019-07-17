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

        //Buscar indice, es decir que va a mostrar la ubicación del nodo que se va a buscar
        //Es similar a los arreglos con las posiciones
        //El indice -1 es una información que el dato no fue encontrado
        public int BuscarIndice(int pDato)
        {
            //Se asigna -1 a n esto se hace porque trabajo está iniciando en el ancla
            //En donde el ancla inicia antes del primer nodo
            int n = -1;
            trabajo = ancla;
            while(trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente; 
                //Se mueve en proporción al recorrido de trabajo, es decir nodo a nodo
                n++;
                //Si, el valor que tiene trabajo es igual al solicitado "pDato"
                //Retorna el valor de n, es decir del indicedionde se ubica el dato
                if (trabajo.Dato == pDato)
                {
                    return n;
                }
            }
            //Si no se encontró el pDato retorna -1 indicando que no está
            return -1;
        }

        //Encuentra el nodo anterior al ingresado
        //Si es el primero retorna el ancla
        //Si el dato no existe trae el último nodo
        public CNodo BuscarAnterior(int pDato)
        {
            //Trabajo2 va a ser igual al ancla para comenzar la busqueda
            trabajo2 = ancla;
            //Mientras trabajo2 sea diferente de null y el nodo siguiente sea diferente a pDato entonces entra al cilo
            while(trabajo2.Siguiente != null && trabajo2.Siguiente.Dato != pDato)
            {
                //Asigna el nodo a trabajo2
                trabajo2 = trabajo2.Siguiente;
            }
            return trabajo2;
        }

        //Borrar la primera ocurrencia del dato suministrado
        public void Borrar(int pDato)
        {
            //Se verifica que hayan datos dentro de los nodos de la lista
            if(EstaVacio() == true)
            {
                return;
            }
            //Se buscan los nodos con los que se quiere trabajar, es decir los que contienen el valor de pDato
            //La idea es tener una referencia al nodo del dato y al nodo anterior
            CNodo anterior = BuscarAnterior(pDato);
            CNodo encontrar = Buscar(pDato);
            //Si no hay nodos para borrar salimos de la función
            if (encontrar == null)
            {
                return;
            }
            //Brincamos el nodo, es decir que lo omitimos
            //Lo que hace es conectar el nodo anterior al dato buscado con el nodo siguiente al nodo del dato buscadi
            anterior.Siguiente = encontrar.Siguiente;
            //Como se "saltó" el nodo encontrado, es posible retirarlo de la lista
            encontrar.Siguiente = null;
        }

        //Inserta el valor que se quiere despupés de la ocurrencia del dato pasado a pDonde
        //pDonde es el dato del nodo desde el cual queremos que se haga la insersión
        //pValor es el dato que se va a insertar en el nuevo nodo
        public void Insertar(int pDonde, int pValor)
        {
            //Se busca y encuentra la posición en donde se desea insertar el dato
            trabajo = Buscar(pDonde);
            //Se hace una verificación para saber si existe el lugar donde se quiere insertar
            if(trabajo == null)
            {
                return;
            }
            //Se crea el nodo temporal que se quiere insertar
            CNodo temp = new CNodo();
            temp.Dato = pValor;
            //Se conecta temp a la lista, es decir que se hace una referencia al valor siguiente
            temp.Siguiente = trabajo.Siguiente;
            //Se conecta trabajo al temp
            trabajo.Siguiente = temp;
        }
        //Inserta el valor que se quiere despupés del ancla
        //pDonde es el dato del nodo desde el cual queremos que se haga la insersión
        //pValor es el dato que se va a insertar en el nuevo nodo
        public void InsertarAlInicio( int pValor)
        {
            //Se asigna el valor del ancla a trabajo
            trabajo = ancla;
            //Se crea el nodo temporal que se quiere insertar
            CNodo temp = new CNodo();
            temp.Dato = pValor;
            //Se conecta temp a la lista, es decir que se hace una referencia al valor siguiente
            temp.Siguiente = trabajo.Siguiente;
            //Se conecta trabajo al temp
            trabajo.Siguiente = temp;
        }
    }
}
