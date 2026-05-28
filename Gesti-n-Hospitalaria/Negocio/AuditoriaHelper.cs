using System;
using Entidad;

namespace Negocio {
    public static class AuditoriaHelper {
        public static void SellarRegistro(BaseEntity entidad) {
            entidad.UsuarioSistema = Sesion.NombreUsuario;
            entidad.FechaSistema = DateTime.Today;
            entidad.HoraSystema = DateTime.Now.TimeOfDay;
        }
    }
}