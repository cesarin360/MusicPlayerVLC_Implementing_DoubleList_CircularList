using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerV1._0.Conexion
{
    class ClsConexion
    {
        String cadena = "Data Source=LAPTOP-E224GM1D;Initial Catalog=Playlist; Integrated Security=true";
        public SqlConnection cn = new SqlConnection();

        public ClsConexion()
        {
            cn.ConnectionString = cadena;
        }

        public void OpenConnection()
        {
            try
            {
                cn.Open();

            }catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un error al conectar con la base de datos."+ e.Message);
            }
        }

        public void CloseConnection()
        {
            cn.Close();
        }

    }
}
