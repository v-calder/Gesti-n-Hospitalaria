using System;

namespace Entidad {
    public class SanatoriosEntity:BaseEntity {
        public int CodigoSanatorio { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public int CapacidadHabitaciones { get; set; }
        public string Telefono { get; set; }
        public string Director { get; set; }
        public string TipoSanatorio { get; set; }
        public decimal CostoOperacionDiario { get; set; }
        public string NivelServicio { get; set; } // Campo autocalculado
    }
}