using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerV1.ListaNodos
{
    class Nodo
    {
        public int dato;
        public Nodo enlace = null;

        public int date{ get => dato; set => dato = value; }
        internal Nodo link { get => enlace; set => enlace = value; }

        public override string ToString()
        {

            return string.Format("[{0}]", dato);
        }
    }
}
