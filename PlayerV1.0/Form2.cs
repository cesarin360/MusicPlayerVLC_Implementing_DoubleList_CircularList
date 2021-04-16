using PlayerV1._0.Conexion;
using PlayerV1._0.ListaPuntos;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace PlayerV1._0
{
    public partial class Playlist_Form : Form
    {
        public Playlist_Form()
        {
            InitializeComponent();
        }
        private Form1 frm = new Form1();
        ClsConexion cn = new ClsConexion();
        private void button1_Click(object sender, EventArgs e)
        {
            String dire = @"C:\Users\josue\Desktop\Universidad\Playlist\" + Plyl_name.Text + ".txt";
            if (track_list2.Items.Count == 0)
            {
                MessageBox.Show("LA LISTA ESTA VACIA.");
            }
            else
            {
                if (Plyl_name.Text == "")
                {
                    MessageBox.Show("POR FAVOR INGRESA UN NOMBRE");
                }
                else
                {
                    String query = "INSERT INTO DIRECCIONES (Direccion) values (@Direccion)";
                    cn.OpenConnection();
                    SqlCommand comando = new SqlCommand(query, cn.cn);
                    comando.Parameters.AddWithValue("@Direccion", dire);
                    comando.ExecuteNonQuery();
                    cn.CloseConnection();
                    StreamWriter sw = new StreamWriter(dire);
                    foreach (object lista in track_list2.Items)
                    {
                        sw.WriteLine(lista.ToString());
                    }
                    sw.Close();
                    MessageBox.Show("EL PLAYLIST SE HA GUARDADO CORRECTAMENTE");
                    Plyl_name.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm1 = new Form3();
            SqlCommand comando = new SqlCommand("SELECT Direccion from DIRECCIONES", cn.cn);
            cn.OpenConnection();
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                frm1.direcciones_c.Items.Add(registros["Direccion"].ToString().Replace("C:\\Users\\josue\\Desktop\\Universidad\\Playlist\\", ""));
                frm1.lst_playlist1.Items.Add(registros["Direccion"].ToString());
            }
            cn.CloseConnection();
            frm1.Show();
            frm1.Refresh();
            /**/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
        }
        private void Playlist_Form_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button3.PerformClick();
        }
    }
}
