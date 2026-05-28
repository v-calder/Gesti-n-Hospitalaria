using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos {
    public class SanatoriosDatos {
        private readonly Conexion conexionDB = new Conexion();

        public List<SanatoriosEntity> ListarSanatorios(string filtro) {
            List<SanatoriosEntity> lista = new List<SanatoriosEntity>();
            string query = @"SELECT * FROM Tbl_Sanatorios 
                             WHERE (Nombre LIKE @filtro OR Ubicacion LIKE @filtro)";

            using(var conn = conexionDB.ObtenerConexion()) {
                using(var cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    try {
                        conn.Open();
                        using(var reader = cmd.ExecuteReader()) {
                            while(reader.Read()) {
                                lista.Add(new SanatoriosEntity {
                                    CodigoSanatorio = Convert.ToInt32(reader["CodigoSanatorio"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Ubicacion = reader["Ubicacion"].ToString(),
                                    CapacidadHabitaciones = Convert.ToInt32(reader["CapacidadHabitaciones"]),
                                    Telefono = reader["Telefono"].ToString(),
                                    Director = reader["Director"].ToString(),
                                    TipoSanatorio = reader["TipoSanatorio"].ToString(),
                                    CostoOperacionDiario = Convert.ToDecimal(reader["CostoOperacionDiario"]),
                                    NivelServicio = reader["NivelServicio"].ToString(),
                                    Estado = Convert.ToBoolean(reader["Estado"])
                                });
                            }
                        }
                    } catch(Exception ex) { throw new Exception("Error al consultar sanatorios: " + ex.Message); }
                }
            }
            return lista;
        }

        public bool InsertarSanatorio(SanatoriosEntity sanatorio) {
            string query = @"INSERT INTO Tbl_Sanatorios (Nombre, Ubicacion, CapacidadHabitaciones, Telefono, Director, TipoSanatorio, CostoOperacionDiario, NivelServicio, Estado, UsuarioSistema, FechaSistema, HoraSistema) 
                             VALUES (@nom, @ubi, @cap, @tel, @dir, @tipo, @costo, @nivel, @est, @user, @fecha, @hora)";
            return EjecutarComando(query, sanatorio, false);
        }

        public bool ActualizarSanatorio(SanatoriosEntity sanatorio) {
            string query = @"UPDATE Tbl_Sanatorios 
                             SET Nombre=@nom, Ubicacion=@ubi, CapacidadHabitaciones=@cap, Telefono=@tel, Director=@dir, TipoSanatorio=@tipo, CostoOperacionDiario=@costo, NivelServicio=@nivel, Estado=@est, UsuarioSistema=@user, FechaSistema=@fecha, HoraSistema=@hora 
                             WHERE CodigoSanatorio=@id";
            return EjecutarComando(query, sanatorio, true);
        }

        public bool EliminarSanatorio(int codigoSanatorio, string usuario) {
            string query = "UPDATE Tbl_Sanatorios SET Estado = 0, UsuarioSistema = @user WHERE CodigoSanatorio = @id";
            using(var conn = conexionDB.ObtenerConexion()) {
                using(var cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@id", codigoSanatorio);
                    cmd.Parameters.AddWithValue("@user", usuario);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private bool EjecutarComando(string query, SanatoriosEntity san, bool esUpdate) {
            using(var conn = conexionDB.ObtenerConexion()) {
                using(var cmd = new SqlCommand(query, conn)) {
                    if(esUpdate)
                        cmd.Parameters.AddWithValue("@id", san.CodigoSanatorio);
                    cmd.Parameters.AddWithValue("@nom", san.Nombre);
                    cmd.Parameters.AddWithValue("@ubi", san.Ubicacion);
                    cmd.Parameters.AddWithValue("@cap", san.CapacidadHabitaciones);
                    cmd.Parameters.AddWithValue("@tel", san.Telefono);
                    cmd.Parameters.AddWithValue("@dir", san.Director);
                    cmd.Parameters.AddWithValue("@tipo", san.TipoSanatorio);
                    cmd.Parameters.AddWithValue("@costo", san.CostoOperacionDiario);
                    cmd.Parameters.AddWithValue("@nivel", san.NivelServicio);
                    cmd.Parameters.AddWithValue("@est", san.Estado);
                    cmd.Parameters.AddWithValue("@user", san.UsuarioSistema);
                    cmd.Parameters.AddWithValue("@fecha", san.FechaSistema);
                    cmd.Parameters.AddWithValue("@hora", san.HoraSystema);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}