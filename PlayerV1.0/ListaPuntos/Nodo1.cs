using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerV1._0.ListaPuntos
{
    public class Nodo1
    {
        public String dato;
        public Nodo1 adelante;
        public Nodo1 atras;

        public String getDato()
        {
            return dato;
        }

        public Nodo1(String entrada)
        {
            dato = entrada;
            adelante = atras = null;
        }
        
    }
}
