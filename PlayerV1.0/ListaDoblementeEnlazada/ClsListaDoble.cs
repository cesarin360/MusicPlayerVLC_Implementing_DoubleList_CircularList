using PlayerV1._0.ListaPuntos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerV1._0.ListaDoblementeEnlazada
{
    public class ClsListaDoble
    {
        public Nodo1 cabeza;//Es el nodo que se llama primero 

        public ClsListaDoble()
        {
            cabeza = null;
        }
        public ClsListaDoble insertaCabezaLista(String entrada)
        {
            Nodo1 nuevo;
            nuevo = new Nodo1(entrada);
            nuevo.adelante = cabeza;
            if (cabeza != null)
            {
                cabeza.atras = nuevo;
            }
            cabeza = nuevo;
            return this;
        }

        public Nodo1 BuscarPosicion(int posicion)
        {
            Nodo1 indice;
            int i;
            if (posicion < 0)
            {
                return null;
            }
            indice = cabeza;
            for(i = 0; i<posicion && indice != null; i++)
            {
                indice = indice.adelante;
            }
            return indice;
        }

        public ClsListaDoble insertaDespues(Nodo1 anterior, String entrada)
        {
            Nodo1 nuevo;
            nuevo = new Nodo1(entrada);
            nuevo.adelante = anterior.adelante;

            if (anterior.adelante != null)
            {
                anterior.adelante.atras = nuevo;
            }
            anterior.adelante = nuevo;
            nuevo.atras = anterior;
            return this;
        }

        public void eliminar(int entrada)
        {
            Nodo1 actual;

            bool encontrado = false;
            actual = cabeza;
            //bucle de busqueda
            while (actual != null && !encontrado)
            {
                encontrado = (actual.dato.Equals(entrada));
                if (!encontrado)
                {
                    actual = actual.adelante;
                }
            }
            //enlace de nodo anterior con el siguiente
            if (actual != null)
            {
                //distinguir entre nodo cabecero del resto de la lista
                if (actual == cabeza)
                {
                    cabeza = actual.adelante;
                    if (actual.adelante != null)
                    {
                        actual.adelante.atras = null;
                    }
                }
                else if (actual.adelante != null)
                { //no es el ultimo nodo
                    actual.atras.adelante = actual.adelante;
                    actual.adelante.atras = actual.atras;
                }
                else
                { //ultimo nodo
                    actual.atras.adelante = null;
                }
                actual = null;
            }

        }
    }
}
