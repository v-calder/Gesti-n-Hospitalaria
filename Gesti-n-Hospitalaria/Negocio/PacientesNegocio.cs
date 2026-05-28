using System;
using System.Collections.Generic;
using Entidad;
using Datos;

namespace Negocio {
    public class PacientesNegocio {
        private readonly PacientesDatos datosPaciente = new PacientesDatos();

        public List<PacientesEntity> BuscarPacientes(string filtro) {
            return datosPaciente.ListarPacientes(filtro.Trim());
        }

        public string GuardarPaciente(PacientesEntity paciente, bool esEdicion) {
            // 1. Validaciones básicas de negocio
            if(string.IsNullOrWhiteSpace(paciente.Nombre) || string.IsNullOrWhiteSpace(paciente.Apellido))
                return "Error: El nombre y apellido del paciente son obligatorios.";

            if(paciente.Dpi <= 0)
                return "Error: El número de DPI ingresado no es válido.";

            if(paciente.FechaNacimiento > DateTime.Today)
                return "Error: La fecha de nacimiento no puede ser una fecha futura.";

            // 2. REQUERIMIENTO: Cálculo automático de la Edad por método
            paciente.Edad = DateTime.Today.Year - paciente.FechaNacimiento.Year;
            if(paciente.FechaNacimiento.Date > DateTime.Today.AddYears(-paciente.Edad)) {
                paciente.Edad--;
            }

            AuditoriaHelper.SellarRegistro(paciente);

            bool respuesta = esEdicion ? datosPaciente.ActualizarPaciente(paciente) : datosPaciente.InsertarPaciente(paciente);
            return respuesta ? "OK" : "No se pudo procesar la transacción del paciente en la base de datos.";
        }

        public bool DarBajaPaciente(int codigoPaciente) {
            return datosPaciente.EliminarPaciente(codigoPaciente, Sesion.NombreUsuario);
        }
    }
}