using System;

namespace Entidad {
    public class PacientesEntity:BaseEntity {
        public int CodigoPaciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Dpi { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
    }
}