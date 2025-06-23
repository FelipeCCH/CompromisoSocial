using CompromisoSocial.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompromisoSocial.Controlador
{
    public class VisitaController
    {
        private string connectionString = "Data Source=educaAccesobd.db;Version=3;";

        // Crear visita
        public bool InsertarVisita(Visita visita)
        {
            try
            {
                using (var conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    string query = @"INSERT INTO Visitas (idVisitante, idUsuario, cedula, nombre, destino, asunto, fechaIngreso, fechaSalida)
                                     VALUES (@idVisitante, @idUsuario, @cedula, @nombre, @destino, @asunto, @fechaIngreso, @fechaSalida)";

                    using (var comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@idVisitante", visita.idVisitante);
                        comando.Parameters.AddWithValue("@idUsuario", visita.idUsuario);
                        comando.Parameters.AddWithValue("@cedula", visita.cedula);
                        comando.Parameters.AddWithValue("@nombre", visita.nombre);
                        comando.Parameters.AddWithValue("@destino", visita.destino);
                        comando.Parameters.AddWithValue("@asunto", visita.asunto);
                        comando.Parameters.AddWithValue("@fechaIngreso", visita.fechaIngreso);
                        comando.Parameters.AddWithValue("@fechaSalida", visita.fechaSalida);

                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar visita: " + ex.Message);
                return false;
            }
        }

        // Leer todas las visitas
        public List<Visita> ObtenerVisitas()
        {
            List<Visita> lista = new List<Visita>();

            using (var conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM Visitas";

                using (var comando = new SQLiteCommand(query, conexion))
                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        lista.Add(new Visita
                        {
                            idVisita = Convert.ToInt32(lector["idVisita"]),
                            idVisitante = Convert.ToInt32(lector["idVisitante"]),
                            idUsuario = Convert.ToInt32(lector["idUsuario"]),
                            cedula = lector["cedula"].ToString(),
                            nombre = lector["nombre"].ToString(),
                            destino = lector["destino"].ToString(),
                            asunto = lector["asunto"].ToString(),
                            fechaIngreso = Convert.ToDateTime(lector["fechaIngreso"]),
                            fechaSalida = Convert.ToDateTime(lector["fechaSalida"])
                        });
                    }
                }
            }

            return lista;
        }

        // Leer visita por ID
        public Visita ObtenerVisitaPorId(int id)
        {
            using (var conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM Visitas WHERE idVisita = @id";

                using (var comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            return new Visita
                            {
                                idVisita = Convert.ToInt32(lector["idVisita"]),
                                idVisitante = Convert.ToInt32(lector["idVisitante"]),
                                idUsuario = Convert.ToInt32(lector["idUsuario"]),
                                cedula = lector["cedula"].ToString(),
                                nombre = lector["nombre"].ToString(),
                                destino = lector["destino"].ToString(),
                                asunto = lector["asunto"].ToString(),
                                fechaIngreso = Convert.ToDateTime(lector["fechaIngreso"]),
                                fechaSalida = Convert.ToDateTime(lector["fechaSalida"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        public Visita obtenerVisitanteCedula(string cedula)
        {
            using (var conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM Visitas WHERE cedula = @cedula";

                using (var comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@cedula", cedula);

                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            return new Visita
                            {
                                idVisita = Convert.ToInt32(lector["idVisita"]),
                                idVisitante = Convert.ToInt32(lector["idVisitante"]),
                                idUsuario = Convert.ToInt32(lector["idUsuario"]),
                                cedula = lector["cedula"].ToString(),
                                nombre = lector["nombre"].ToString(),
                                destino = lector["destino"].ToString(),
                                asunto = lector["asunto"].ToString(),
                                fechaIngreso = Convert.ToDateTime(lector["fechaIngreso"]),
                                fechaSalida = Convert.ToDateTime(lector["fechaSalida"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        // Actualizar visita
        public bool ActualizarVisita(int id, Visita visita)
        {
            try
            {
                using (var conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    string query = @"UPDATE Visitas SET 
                                     idVisitante = @idVisitante, 
                                     idUsuario = @idUsuario, 
                                     cedula = @cedula, 
                                     nombre = @nombre, 
                                     destino = @destino, 
                                     asunto = @asunto, 
                                     fechaIngreso = @fechaIngreso, 
                                     fechaSalida = @fechaSalida 
                                     WHERE idVisita = @id";

                    using (var comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@idVisitante", visita.idVisitante);
                        comando.Parameters.AddWithValue("@idUsuario", visita.idUsuario);
                        comando.Parameters.AddWithValue("@cedula", visita.cedula);
                        comando.Parameters.AddWithValue("@nombre", visita.nombre);
                        comando.Parameters.AddWithValue("@destino", visita.destino);
                        comando.Parameters.AddWithValue("@asunto", visita.asunto);
                        comando.Parameters.AddWithValue("@fechaIngreso", visita.fechaIngreso);
                        comando.Parameters.AddWithValue("@fechaSalida", visita.fechaSalida);
                        comando.Parameters.AddWithValue("@id", id);

                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar visita: " + ex.Message);
                return false;
            }
        }

        // Leer visitas por fecha
        public List<Visita> ObtenerVisitasPorFecha(DateTime fecha)
        {
            List<Visita> lista = new List<Visita>();

            using (var conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = @"SELECT * FROM Visitas WHERE fechaIngreso >= @fechaInicio AND fechaIngreso <  @fechaFin";

                using (var comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@fechaInicio", fecha.Date);
                    comando.Parameters.AddWithValue("@fechaFin", fecha.Date.AddDays(1));

                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            lista.Add(new Visita
                            {
                                idVisita = Convert.ToInt32(lector["idVisita"]),
                                idVisitante = Convert.ToInt32(lector["idVisitante"]),
                                idUsuario = Convert.ToInt32(lector["idUsuario"]),
                                cedula = lector["cedula"].ToString(),
                                nombre = lector["nombre"].ToString(),
                                destino = lector["destino"].ToString(),
                                asunto = lector["asunto"].ToString(),
                                fechaIngreso = Convert.ToDateTime(lector["fechaIngreso"]),
                                fechaSalida = Convert.ToDateTime(lector["fechaSalida"])
                            });
                        }
                    }
                }
            }

            return lista;
        }



        // Eliminar visita
        public bool EliminarVisita(int id)
        {
            try
            {
                using (var conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    string query = "DELETE FROM Visitas WHERE idVisita = @id";

                    using (var comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", id);
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar visita: " + ex.Message);
                return false;
            }
        }
    }
}

