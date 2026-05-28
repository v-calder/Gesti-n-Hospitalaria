using System;

namespace Entidad {
    public class SegurosMedicosEntity {
        public int CodigoSeguro { get; set; }
        public string NombreSeguro { get; set; }
        public string TipoSeguro { get; set; }
        public decimal PorcentajeCobertura { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public decimal MontoMaximo { get; set; }
        public string CorreoContacto { get; set; }
        public bool Estado { get; set; }

        public string UsuarioSistema { get; set; }
        public DateTime FechaSistema { get; set; }
        public TimeSpan HoraSystema { get; set; }
    }
}