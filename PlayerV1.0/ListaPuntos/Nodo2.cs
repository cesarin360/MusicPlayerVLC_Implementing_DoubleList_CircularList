using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerV1._0.ListaPuntos
{
    public class Nodo2
    {
        public String dato;
        public Nodo2 enlace;

        public Nodo2(String entrada)
        {
            dato = entrada;
            enlace = this;
        }
    }
}
