using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerV1.ListaNodos
{
    class Listas
    {
        public Nodo start;
        public Nodo Linked_List;
        public Nodo Linked_List1;
        public Listas()
        {
            //Estamos inicializando el comienzo de la lista y le damos el final
            start = new Nodo();
            start.enlace = null;
        }

        public void visualizar()
        {
            Linked_List = start;
            while (Linked_List.enlace != null)
            {
                Linked_List = Linked_List.enlace;
                int n = Linked_List.date;

                MessageBox.Show("{0}", n.ToString());
            }
        }
    }
}
