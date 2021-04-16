using PlayerV1.ListaNodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerV1.objListas
{
    class List : Listas
    {
        public List() : base() { }

        public List insertaOrden(int entrada)
        {
            Linked_List = start;
            while(Linked_List.enlace != null)
            {
                Linked_List = Linked_List.enlace;
            }

            Nodo tmp = new Nodo();
            tmp.date = entrada;
            tmp.enlace = null;
            Linked_List.enlace = tmp;

            return this;
        }

        public Nodo search(int entrada)
        {
            Linked_List1 = start;
            while (Linked_List1.enlace != null)
            {
                Linked_List1 = Linked_List1.enlace;
                if (Linked_List1.date == entrada)
                {
                    return Linked_List1;
                }
                int pausa;
                pausa = 0;
            }
            return null;
        }

        public int indice(int entrada)
        {
            int n = -1;
            Linked_List = start;

            while(Linked_List.enlace != null)
            {
                Linked_List = Linked_List.enlace;
                n++;

                if(Linked_List.date == entrada)
                {
                    return n;
                }
            }
            return -1;
        }

        public Nodo enlace(int entrada)
        {
            Linked_List1 = start;
            while(Linked_List1.enlace != null && Linked_List1.date != entrada)
            {
                Linked_List1 = Linked_List1.enlace;
            }
            return Linked_List1;
        }
        public void delete(int entrada)
        {

            Nodo PreviousNodo = enlace(entrada);
            Nodo this_Nodo = search(entrada);

            if (this_Nodo == null)
            {
                MessageBox.Show("NO SE HA ENCONTRADO EL NODO");
                return;
            }
            else
            {
                PreviousNodo.enlace = this_Nodo.enlace;
                this_Nodo.enlace = null;
            }
        }
    }
}
