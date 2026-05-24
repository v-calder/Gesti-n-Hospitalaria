using System;
using System.Collections.Generic;
using Entidad;
using Datos;

namespace Negocio {
    public class SegurosMedicosNegocio {
        private readonly SegurosMedicosDatos datosSeguro = new SegurosMedicosDatos();

        public List<SegurosMedicosEntity> BuscarSeguros(string filtro) {
            return datosSeguro.ListarSeguros(filtro.Trim());
        }

        public string GuardarSeguro(SegurosMedicosEntity seguro, bool esEdicion) {
            // Validaciones de negocio
            if(string.IsNullOrWhiteSpace(seguro.NombreSeguro))
                return "Error: El nombre de la aseguradora es mandatorio.";

            if(seguro.PorcentajeCobertura < 0 || seguro.PorcentajeCobertura > 100)
                return "Error: El porcentaje de cobertura debe situarse entre 0% y 100%.";

            if(seguro.MontoMaximo <= 0)
                return "Error: El monto máximo de cobertura debe ser mayor a Q0.00.";

            seguro.UsuarioSistema = Sesion.NombreUsuario;
            seguro.FechaSistema = DateTime.Today;
            seguro.HoraSystema = DateTime.Now.TimeOfDay;

            bool respuesta = esEdicion ? datosSeguro.ActualizarSeguro(seguro) : datosSeguro.InsertarSeguro(seguro);

            return respuesta ? "OK" : "No se pudo procesar la transacción en la base de datos.";
        }

        public bool DarBajaSeguro(int codigoSeguro) {
            return datosSeguro.EliminarSeguro(codigoSeguro, Sesion.NombreUsuario);
        }
    }
}