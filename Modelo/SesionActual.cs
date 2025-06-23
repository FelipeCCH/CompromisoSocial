using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompromisoSocial
{
    public static class SesionActual
    {
        public static int IdUsuario { get; set; }
        public static string Nombre { get; set; }
        public static string Rol { get; set; }

        public static void Cargar(int idUsuario, string nombre, string rol)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Rol = rol;
        }

        public static void Cerrar()
        {
            IdUsuario = 0;
            Nombre = null;
            Rol = null;
        }
    }
}

