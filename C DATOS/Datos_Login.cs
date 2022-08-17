using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_MODELO;

namespace C_DATOS
{
    public class Datos_Login
    {

        Conexion conn = new Conexion();

        public UsuarioCache LoginUser(String usuario, String contraseña)
        {
            SqlConnection sql_conexion = conn.abrir_conexion();
            UsuarioCache usuarioCache = new UsuarioCache();
            string sentencia = "select * from USUARIO where (NOMBRE_USUARIO= @usuario or CORREO= @usuario )and CONTRASENIA = @contraseniia;";

            try
            {   
                SqlCommand sql_comando = new SqlCommand(sentencia, sql_conexion); //Para ejecutar 
                sql_comando.Parameters.AddWithValue("@usuario", usuario);
                sql_comando.Parameters.AddWithValue("@contraseniia", contraseña);
                SqlDataReader registros = sql_comando.ExecuteReader();
                if (registros.HasRows)
                {
                    while (registros.Read())
                    {
                        usuarioCache.Nombres = registros["NOMBRE_USUARIO"].ToString();
                        usuarioCache.Apellidos = registros["NOMBRE_USUARIO"].ToString();
                    }
                }
                else
                {
                    usuarioCache = null;
                }
                conn.cerrar_conexion(sql_conexion);
            }
            catch
            {
                conn.cerrar_conexion(sql_conexion);
                usuarioCache = null;
            }
            finally
            {
                conn.cerrar_conexion(sql_conexion);
            }
            return usuarioCache;
        }



    }
}
