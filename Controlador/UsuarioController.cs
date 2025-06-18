using System;
using System.Collections.Generic;
using System.Data.SQLite; // ✅ Usa esta librería correctamente
using System.Windows.Forms;
using EduAcceso.Modelo;

namespace EduAcceso.Controlador
{
    public class UsuarioController
    {
        private string connectionString = "Data Source=educaAccesobd.db;Version=3;";

        public Usuario VerificarLogin(string correo, string clave)
        {
            using (var conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM Usuarios WHERE correo = @correo AND clave = @clave";

                using (var comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@correo", correo);
                    comando.Parameters.AddWithValue("@clave", clave);

                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            return new Usuario
                            {
                                idUsuario = Convert.ToInt32(lector["IdUsuario"]),
                                nombre = lector["nombre"].ToString(),
                                correo = lector["correo"].ToString(),
                                telefono = Convert.ToInt32(lector["telefono"]),
                                clave = lector["clave"].ToString(),
                                rol = lector["rol"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public bool InsertarUsuario(Usuario nuevoUsuario)
        {
            try
            {
                using (var conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    string query = "INSERT INTO Usuarios (nombre, correo, telefono, clave, rol) " +
                                   "VALUES (@nombre, @correo, @telefono, @clave, @rol)";

                    using (var comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nuevoUsuario.nombre);
                        comando.Parameters.AddWithValue("@correo", nuevoUsuario.correo);
                        comando.Parameters.AddWithValue("@telefono", nuevoUsuario.telefono);
                        comando.Parameters.AddWithValue("@clave", nuevoUsuario.clave);
                        comando.Parameters.AddWithValue("@rol", nuevoUsuario.rol);

                        int resultado = comando.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar usuario: " + ex.Message);
                return false;
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (var conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM Usuarios";

                using (var comando = new SQLiteCommand(query, conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            usuarios.Add(new Usuario
                            {
                                idUsuario = Convert.ToInt32(lector["idUsuario"]),
                                nombre = lector["nombre"].ToString(),
                                correo = lector["correo"].ToString(),
                                telefono = Convert.ToInt32(lector["telefono"]),
                                clave = lector["clave"].ToString(),
                                rol = lector["rol"].ToString()
                            });
                        }
                    }
                }
            }

            return usuarios;
        }
    }
}
