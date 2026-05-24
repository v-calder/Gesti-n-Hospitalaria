using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos {
    public class SegurosMedicosDatos {
        private readonly Conexion conexionDB = new Conexion();

        // 1. SELECT (Listar todo o buscar por filtro de texto)
        public List<SegurosMedicosEntity> ListarSeguros(string filtro) {
            List<SegurosMedicosEntity> lista = new List<SegurosMedicosEntity>();
            string query = @"SELECT * FROM Tbl_SegurosMedicos 
                             WHERE (NombreSeguro LIKE @filtro OR TipoSeguro LIKE @filtro) 
                             AND Estado = 1";

            using(var conn = conexionDB.ObtenerConexion()) {
                using(var cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    try {
                        conn.Open();
                        using(var reader = cmd.ExecuteReader()) {
                            while(reader.Read()) {
                                lista.Add(new SegurosMedicosEntity {
                                    CodigoSeguro = Convert.ToInt32(reader["CodigoSeguro"]),
                                    NombreSeguro = reader["NombreSeguro"].ToString(),
                                    TipoSeguro = reader["TipoSeguro"].ToString(),
                                    PorcentajeCobertura = Convert.ToDecimal(reader["PorcentajeCobertura"]),
                                    Telefono = reader["Telefono"].ToString(),
                                    Direccion = reader["Direccion"].ToString(),
                                    MontoMaximo = Convert.ToDecimal(reader["MontoMaximo"]),
                                    CorreoContacto = reader["CorreoContacto"].ToString(),
                                    Estado = Convert.ToBoolean(reader["Estado"])
                                });
                            }
                        }
                    } catch(Exception ex) { throw new Exception("Error al consultar seguros: " + ex.Message); }
                }
            }
            return lista;
        }

        // 2. INSERT (Guardar registro nuevo)
        public bool InsertarSeguro(SegurosMedicosEntity seguro) {
            string query = @"INSERT INTO Tbl_SegurosMedicos (NombreSeguro, TipoSeguro, PorcentajeCobertura, Telefono, Direccion, MontoMaximo, Estado, UsuarioSistema, FechaSistema, HoraSistema) 
                             VALUES (@nom, @tipo, @cober, @tel, @dir, @max, @est, @user, @fecha, @hora)";
            return EjecutarComando(query, seguro, false);
        }

        // 3. UPDATE (Editar registro existente)
        public bool ActualizarSeguro(SegurosMedicosEntity seguro) {
            string query = @"UPDATE Tbl_SegurosMedicos 
                             SET NombreSeguro=@nom, TipoSeguro=@tipo, PorcentajeCobertura=@cober, Telefono=@tel, Direccion=@dir, MontoMaximo=@max, Estado=@est, UsuarioSistema=@user, FechaSistema=@fecha, HoraSistema=@hora 
                             WHERE CodigoSeguro=@id";
            return EjecutarComando(query, seguro, true);
        }

        // 4. DELETE (Desactivar cambiando Estado a 0)
        public bool EliminarSeguro(int codigoSeguro, string usuario) {
            string query = "UPDATE Tbl_SegurosMedicos SET Estado = 0, UsuarioSistema = @user WHERE CodigoSeguro = @id";
            using(var conn = conexionDB.ObtenerConexion()) {
                using(var cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@id", codigoSeguro);
                    cmd.Parameters.AddWithValue("@user", usuario);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        
        private bool EjecutarComando(string query, SegurosMedicosEntity seg, bool esUpdate) {
            using(var conn = conexionDB.ObtenerConexion()) {
                using(var cmd = new SqlCommand(query, conn)) {
                    if(esUpdate)
                        cmd.Parameters.AddWithValue("@id", seg.CodigoSeguro);
                    cmd.Parameters.AddWithValue("@nom", seg.NombreSeguro);
                    cmd.Parameters.AddWithValue("@tipo", seg.TipoSeguro);
                    cmd.Parameters.AddWithValue("@cober", seg.PorcentajeCobertura);
                    cmd.Parameters.AddWithValue("@tel", seg.Telefono);
                    cmd.Parameters.AddWithValue("@dir", seg.Direccion);
                    cmd.Parameters.AddWithValue("@max", seg.MontoMaximo);
                    cmd.Parameters.AddWithValue("@est", seg.Estado);
                    cmd.Parameters.AddWithValue("@user", seg.UsuarioSistema);
                    cmd.Parameters.AddWithValue("@fecha", seg.FechaSistema);
                    cmd.Parameters.AddWithValue("@hora", seg.HoraSystema);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}