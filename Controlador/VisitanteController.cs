using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using CompromisoSocial.Modelo;

namespace CompromisoSocial.Controlador
{
    public class VisitanteController
    {
        private string connectionString = "Data Source=educaAccesobd.db;Version=3;";

        // Crear
        public bool InsertarVisitante(Visitante visitante)
        {
            try
            {
                using (var conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    string query = "INSERT INTO Visitante (cedula, nombre, correo, telefono, direccion) " +
                                   "VALUES (@cedula, @nombre, @correo, @telefono, @direccion)";

                    using (var comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@cedula", visitante.cedula);
                        comando.Parameters.AddWithValue("@nombre", visitante.nombre);
                        comando.Parameters.AddWithValue("@correo", visitante.correo);
                        comando.Parameters.AddWithValue("@telefono", visitante.telefono);
                        comando.Parameters.AddWithValue("@direccion", visitante.direccion);

                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar visitante: " + ex.Message);
                return false;
            }
        }

        // Leer todos
        public List<Visitante> ObtenerVisitantes()
        {
            List<Visitante> lista = new List<Visitante>();

            using (var conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM Visitante";

                using (var comando = new SQLiteCommand(query, conexion))
                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        lista.Add(new Visitante
                        {
                            idVisitante = Convert.ToInt32(lector["idVisitante"]),
                            cedula = lector["cedula"].ToString(),
                            nombre = lector["nombre"].ToString(),
                            correo = lector["correo"].ToString(),
                            telefono = Convert.ToInt32(lector["telefono"]),
                            direccion = Convert.ToInt32(lector["direccion"])
                        });
                    }
                }
            }

            return lista;
        }

        // Leer por ID
        public Visitante ObtenerVisitantePorId(int id)
        {
            using (var conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM Visitante WHERE idVisitante = @id";

                using (var comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            return new Visitante
                            {
                                idVisitante = Convert.ToInt32(lector["idVisitante"]),
                                cedula = lector["cedula"].ToString(),
                                nombre = lector["nombre"].ToString(),
                                correo = lector["correo"].ToString(),
                                telefono = Convert.ToInt32(lector["telefono"]),
                                direccion = Convert.ToInt32(lector["direccion"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        // Actualizar
        public bool ActualizarVisitante(Visitante visitante)
        {
            try
            {
                using (var conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    string query = "UPDATE Visitante SET cedula = @cedula, nombre = @nombre, correo = @correo, " +
                                   "telefono = @telefono, direccion = @direccion WHERE idVisitante = @idVisitante";

                    using (var comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@cedula", visitante.cedula);
                        comando.Parameters.AddWithValue("@nombre", visitante.nombre);
                        comando.Parameters.AddWithValue("@correo", visitante.correo);
                        comando.Parameters.AddWithValue("@telefono", visitante.telefono);
                        comando.Parameters.AddWithValue("@direccion", visitante.direccion);
                        comando.Parameters.AddWithValue("@idVisitante", visitante.idVisitante);

                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar visitante: " + ex.Message);
                return false;
            }
        }

        // Eliminar
        public bool EliminarVisitante(int id)
        {
            try
            {
                using (var conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    string query = "DELETE FROM Visitante WHERE idVisitante = @id";

                    using (var comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", id);
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar visitante: " + ex.Message);
                return false;
            }
        }
    }
}
