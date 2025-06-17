using EduAccesoApp.Model;
using EduAccesoApp.Data;
using Microsoft.Data.Sqlite;

namespace EduAccesoApp.Controller
{
        public class UsuarioController
    {
        public Usuario? Login(string correo, string clave)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Usuarios WHERE correo = @correo AND clave = @clave";
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@clave", clave);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Usuario
                {
                    idUsuario = reader.GetInt32(0),
                    nombre = reader.GetString(1),
                    correo = reader.GetString(2),
                    telefono = reader.GetInt32(3),
                    clave = reader.GetString(4),
                    rol = reader.GetString(5)
                };
            }

            return null;
        }
    }

}
