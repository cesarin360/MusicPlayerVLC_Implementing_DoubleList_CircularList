using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerV1._0
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private Form1 frm = new Form1();
        private void button2_Click(object sender, EventArgs e)
        {
            lst_playlist1.SelectedIndex = direcciones_c.SelectedIndex;
            String n = lst_playlist1.SelectedItem.ToString();
            StreamReader sr = new StreamReader(Convert.ToString(@"" + n));
            while (sr.Peek() >= 0)
            {
                track_list2.Items.Add(Convert.ToString(sr.ReadLine()));

            }
            sr.Close();
            int contador = 0;
            foreach (String dato in track_list2.Items)
            {
                frm.addfiles.insertaCabezaLista(dato);
                frm.addfiles1.insertar(dato);
                frm.n += contador += 1;
            }
            frm.lista1 =frm.addfiles1.lc.enlace;
            for (int i = 0; i < contador; i++)
            {
                frm.track_list.Items.Add(frm.lista1.dato.Replace("C:\\Users\\josue\\Music\\", ""));
                frm.lista1 = frm.lista1.enlace;
            }
            this.Close();
            frm.Refresh();
            frm.check_bucle.Visible = true;
            frm.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btn_play.PerformClick();
        }
    }
}
