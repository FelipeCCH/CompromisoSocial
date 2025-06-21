using CompromisoSocial.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite; // ✅ Usa esta librería correctamente
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CompromisoSocial.Controlador
{
    public class UsuarioController
    {
        private string connectionString = "Data Source=educaAccesobd.db;Version=3;";

        // Login
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

        // Crear
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

        // Leer por ID
        public Usuario ObtenerUsuarioPorId(int id)
        {
            using (var conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM Usuarios WHERE idUsuario = @id";

                using (var comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            return new Usuario
                            {
                                idUsuario = Convert.ToInt32(lector["idUsuario"]),
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

        // Leer todos
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

        // Actualizar
        public bool ActualizarUsuario(Usuario usuarioActualizado)
        {
            try
            {
                using (var conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    string query = "UPDATE Usuarios SET nombre = @nombre, correo = @correo, telefono = @telefono, clave = @clave, rol = @rol " +
                                "WHERE idUsuario = @idUsuario";

                    using (var comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", usuarioActualizado.nombre);
                        comando.Parameters.AddWithValue("@correo", usuarioActualizado.correo);
                        comando.Parameters.AddWithValue("@telefono", usuarioActualizado.telefono);
                        comando.Parameters.AddWithValue("@clave", usuarioActualizado.clave);
                        comando.Parameters.AddWithValue("@rol", usuarioActualizado.rol);
                        comando.Parameters.AddWithValue("@idUsuario", usuarioActualizado.idUsuario);

                        int resultado = comando.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario: " + ex.Message);
                return false;
            }
        }

        // Eliminar
        public bool EliminarUsuario(int id)
        {
            try
            {
                using (var conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    string query = "DELETE FROM Usuarios WHERE idUsuario = @id";

                    using (var comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", id);
                        int resultado = comando.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
                return false;
            }
        }


        // Encriptar Contraseña
        public string EncriptarClave(string clave)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(clave);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

    }
}
