using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_MODELO
{
    public class UsuarioCache
    {
        private string nombres;
        private string apellidos;
        
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }

    }
}
