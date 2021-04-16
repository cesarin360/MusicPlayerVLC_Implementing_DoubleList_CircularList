using PlayerV1.ListaNodos;
using PlayerV1.objListas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List n;
        private void button1_Click(object sender, EventArgs e)
        {
            
            n.insertaOrden(1);
            n.insertaOrden(65);
            n.insertaOrden(45);
            n.visualizar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = new List();
            n.delete(1);
            n.visualizar();
        }
    }
}
