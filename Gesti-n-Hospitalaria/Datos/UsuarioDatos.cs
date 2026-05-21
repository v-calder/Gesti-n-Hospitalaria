using System;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class UsuarioDatos
    {
        private readonly Conexion conexionBase = new Conexion();

        public UsuarioEntity ValidarAcceso(string usuario, string password)
        {
            UsuarioEntity usuarioEncontrado = null;
            string query = @"SELECT CodigoUsuario, NombreUsuario, CodigoRol, Estado 
                             FROM Tbl_Usuarios 
                             WHERE NombreUsuario = @user AND Contrasena = @pass AND Estado = 1";

            using (var conn = conexionBase.ObtenerConexion())
            {
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = usuario;
                    cmd.Parameters.Add("@pass", SqlDbType.VarChar, 255).Value = password;

                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                usuarioEncontrado = new UsuarioEntity
                                {
                                    CodigoUsuario = Convert.ToInt32(reader["CodigoUsuario"]),
                                    NombreUsuario = reader["NombreUsuario"].ToString(),
                                    CodigoRol = Convert.ToInt32(reader["CodigoRol"]),
                                    Estado = Convert.ToBoolean(reader["Estado"])
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error en la autenticación de datos: " + ex.Message);
                    }
                }
            }
            return usuarioEncontrado;
        }
    }
}