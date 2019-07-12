using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_Ligada
{
    class CNodo
    {
        //Aquí colocamos el dato o datos que guarda el nodo
        //Si quiero guardar muchos datos agrego varios nodos con cada elemento que se necesita
        private int dato;
        //Esta variable de referencia usada para apuntar al nodo siguiente 
        //Una variable de referencia es una variable que puede ser referencia a cualquier instancia del mismo tipo de la clase
        //o a tipos que decienden de esa cadena de herencia 
        private CNodo siguiente = null;
        //Propiedades a usar

        public int Dato { get => dato; set => dato = value; }

        internal CNodo Siguiente { get => siguiente; set => siguiente = value; }
        //Para poder inprimirlo
        public override string ToString()
        {
            return string.Format("[{0}]",dato);
        }
    }
}
