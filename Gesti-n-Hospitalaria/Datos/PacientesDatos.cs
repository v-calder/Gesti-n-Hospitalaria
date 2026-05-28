using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos {
    public class PacientesDatos {
        private readonly Conexion conexionDB = new Conexion();

        // 1. SELECT (Listar todos los pacientes o filtrar por nombre/apellido)
        public List<PacientesEntity> ListarPacientes(string filtro) {
            List<PacientesEntity> lista = new List<PacientesEntity>();
            string query = @"SELECT * FROM Tbl_Pacientes 
                             WHERE (Nombre LIKE @filtro OR Apellido LIKE @filtro)";

            using(var conn = conexionDB.ObtenerConexion()) {
                using(var cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    try {
                        conn.Open();
                        using(var reader = cmd.ExecuteReader()) {
                            while(reader.Read()) {
                                lista.Add(new PacientesEntity {
                                    CodigoPaciente = Convert.ToInt32(reader["CodigoPaciente"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    Dpi = Convert.ToInt64(reader["Dpi"]),
                                    FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                    Genero = reader["Genero"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Direccion = reader["Direccion"].ToString(),
                                    Edad = Convert.ToInt32(reader["Edad"]),
                                    Estado = Convert.ToBoolean(reader["Estado"])
                                });
                            }
                        }
                    } catch(Exception ex) { throw new Exception("Error al consultar pacientes: " + ex.Message); }
                }
            }
            return lista;
        }

        // 2. INSERT (Guardar nuevo paciente)
        public bool InsertarPaciente(PacientesEntity paciente) {
            string query = @"INSERT INTO Tbl_Pacientes (Nombre, Apellido, Dpi, FechaNacimiento, Genero, Telefono, Direccion, Edad, Estado, UsuarioSistema, FechaSistema, HoraSistema) 
                             VALUES (@nom, @ape, @dpi, @fnac, @gen, @tel, @dir, @edad, @est, @user, @fecha, @hora)";
            return EjecutarComando(query, paciente, false);
        }

        // 3. UPDATE (Modificar paciente existente)
        public bool ActualizarPaciente(PacientesEntity paciente) {
            string query = @"UPDATE Tbl_Pacientes 
                             SET Nombre=@nom, Apellido=@ape, Dpi=@dpi, FechaNacimiento=@fnac, Genero=@gen, Telefono=@tel, Direccion=@dir, Edad=@edad, Estado=@est, UsuarioSistema=@user, FechaSistema=@fecha, HoraSistema=@hora 
                             WHERE CodigoPaciente=@id";
            return EjecutarComando(query, paciente, true);
        }

        // 4. DELETE (elimir un paciente)
        public bool EliminarPaciente(int codigoPaciente, string usuario) {
            string query = "UPDATE Tbl_Pacientes SET Estado = 0, UsuarioSistema = @user WHERE CodigoPaciente = @id";
            using(var conn = conexionDB.ObtenerConexion()) {
                using(var cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@id", codigoPaciente);
                    cmd.Parameters.AddWithValue("@user", usuario);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private bool EjecutarComando(string query, PacientesEntity pac, bool esUpdate) {
            using(var conn = conexionDB.ObtenerConexion()) {
                using(var cmd = new SqlCommand(query, conn)) {
                    if(esUpdate)
                        cmd.Parameters.AddWithValue("@id", pac.CodigoPaciente);
                    cmd.Parameters.AddWithValue("@nom", pac.Nombre);
                    cmd.Parameters.AddWithValue("@ape", pac.Apellido);
                    cmd.Parameters.AddWithValue("@dpi", pac.Dpi);
                    cmd.Parameters.AddWithValue("@fnac", pac.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@gen", pac.Genero);
                    cmd.Parameters.AddWithValue("@tel", pac.Telefono);
                    cmd.Parameters.AddWithValue("@dir", pac.Direccion);
                    cmd.Parameters.AddWithValue("@edad", pac.Edad);
                    cmd.Parameters.AddWithValue("@est", pac.Estado);
                    cmd.Parameters.AddWithValue("@user", pac.UsuarioSistema);
                    cmd.Parameters.AddWithValue("@fecha", pac.FechaSistema);
                    cmd.Parameters.AddWithValue("@hora", pac.HoraSystema);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}