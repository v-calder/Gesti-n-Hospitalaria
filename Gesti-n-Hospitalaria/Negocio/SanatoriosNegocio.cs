using System;
using System.Collections.Generic;
using Entidad;
using Datos;

namespace Negocio {
    public class SanatoriosNegocio {
        private readonly SanatoriosDatos datosSanatorio = new SanatoriosDatos();

        public List<SanatoriosEntity> BuscarSanatorios(string filtro) {
            return datosSanatorio.ListarSanatorios(filtro.Trim());
        }

        public string GuardarSanatorio(SanatoriosEntity sanatorio, bool esEdicion) {
            if(string.IsNullOrWhiteSpace(sanatorio.Nombre) || string.IsNullOrWhiteSpace(sanatorio.Ubicacion))
                return "Error: El nombre y la ubicación del sanatorio son campos mandatorios.";

            if(sanatorio.CostoOperacionDiario < 0)
                return "Error: El costo de operación diario no puede ser un valor negativo.";

            if(sanatorio.CapacidadHabitaciones > 100) {
                sanatorio.NivelServicio = "Alto";
            } else {
                sanatorio.NivelServicio = "Medio";
            }

            AuditoriaHelper.SellarRegistro(sanatorio);

            bool respuesta = esEdicion ? datosSanatorio.ActualizarSanatorio(sanatorio) : datosSanatorio.InsertarSanatorio(sanatorio);
            return respuesta ? "OK" : "No se pudo procesar la transacción del sanatorio en la base de datos.";
        }

        public bool DarBajaSanatorio(int codigoSanatorio) {
            return datosSanatorio.EliminarSanatorio(codigoSanatorio, Sesion.NombreUsuario);
        }
    }
}