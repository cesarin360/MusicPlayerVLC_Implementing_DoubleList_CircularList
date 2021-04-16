using PlayerV1._0.ListaPuntos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerV1._0.CircularDefinicion
{
    public class ClsListaCircularBase
    {
        public Nodo2 lc;

        public ClsListaCircularBase()
        {
            lc = null;
        }

        public ClsListaCircularBase insertar(String entrada)
        {
            Nodo2 nuevo;
            nuevo = new Nodo2(entrada);
            if (lc != null)
            {
                nuevo.enlace = lc.enlace;
                lc.enlace = nuevo;
            }
            lc = nuevo;
            return this;
        }

        public void eliminar(int entrada)
        {
            Nodo2 actual;
            bool encontrado = false;
            //Buclle de busqueda
            actual = lc;
            while ((actual.enlace != lc) && (!encontrado))
            {
                encontrado = actual.enlace.dato.Equals(entrada);
                if (!encontrado)
                {
                    actual = actual.enlace;
                }
            }
            encontrado = actual.enlace.dato.Equals(entrada);
            if (encontrado)
            {
                Nodo2 p;
                p = actual.enlace;
                if (lc == lc.enlace)
                {
                    lc = null;

                }
                else
                {
                    if (p == lc)
                    {
                        lc = actual;
                    }
                    actual.enlace = p.enlace;
                }
                p = null;

            }
        }
    }
}
