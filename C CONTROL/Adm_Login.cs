using C_DATOS;
using C_MODELO;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_CONTROL
{
    public class Adm_Login
    {

        private static Adm_Login adm = null;
        UsuarioCache usuarioCache = null;

        private Adm_Login()
        {
            usuarioCache = new UsuarioCache();
        }

        // Getter: GetAdm
        public static Adm_Login GetAdm()
        {
            if (adm == null)
            {                  //3.2
                adm = new Adm_Login();
            }
            return adm;
        }



        /*--------------------------Frm_Login-----------------------------------------*/

        Datos_Login datosLogin = new Datos_Login();

        public bool LoginUser(String usuario, String contra)
        {
            usuarioCache = datosLogin.LoginUser(usuario, contra);
            if (usuarioCache is null)
            {
                return false;
            }
            else
            {
                return true;

            }
        }


        /*--------------------------Frm_Menu-----------------------------------------*/

        public void CargarDatos(Label lblnombre)
        {
            lblnombre.Text = usuarioCache.Nombres;
        }

       
        public string NombreUsuario()
        {
            return usuarioCache.Nombres;
        }

        public string ApellidoUsuario()
        {
            return usuarioCache.Apellidos;
        }


    }
}
