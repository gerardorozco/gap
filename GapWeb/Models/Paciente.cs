using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GapWeb.Models
{
    public class Paciente
    {
        [Required(ErrorMessage = "Documento Paciente es Obligatorio")]
        [Display(Name = "Documento")]
        public string IdPaciente { get; set; }

        [Required(ErrorMessage = "Nombre Paciente es Obligatorio")]
        [Display(Name = "Nombre Paciente")]
        public string NombrePaciente { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Teléfono debe ser numérico")]
        public string Telefono { get; set; }

        public string Direccion { get; set; }
    }
}