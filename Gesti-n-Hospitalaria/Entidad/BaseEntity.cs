using System;

namespace Entidad {
    public abstract class BaseEntity {
        public bool Estado { get; set; } = true;
        public string UsuarioSistema { get; set; }
        public DateTime FechaSistema { get; set; }
        public TimeSpan HoraSystema { get; set; }
    }
}