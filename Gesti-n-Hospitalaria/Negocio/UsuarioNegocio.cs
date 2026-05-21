using System;
using Entidad;
using Datos;

namespace Negocio
{
    public class UsuarioNegocio
    {
        private readonly UsuarioDatos datosUsuario = new UsuarioDatos();

        public UsuarioEntity AutenticarUsuario(string usuario, string password)
        {
            // Validaciones iniciales
            if (string.IsNullOrWhiteSpace(usuario))
                throw new ArgumentException("El nombre de usuario no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("La contraseña no puede estar vacía.");

            // Petición a la capa de datos
            return datosUsuario.ValidarAcceso(usuario.Trim(), password);
        }
    }
}