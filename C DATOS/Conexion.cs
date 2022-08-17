using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_DATOS
{
    public class Conexion
    {
        public SqlConnection abrir_conexion()
        {
            string ConnectionString = "server=localhost; database=DENTALAVSMILE; integrated security=true";
            SqlConnection conexion = new SqlConnection(ConnectionString);
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            return conexion;
        }

        //Cerrar conexion a BD
        public void cerrar_conexion(SqlConnection conexion)
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
