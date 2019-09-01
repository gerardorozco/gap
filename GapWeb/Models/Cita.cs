using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GapWeb.Models
{
    public class Cita
    {
        public int TipoCita { get; set; }

        public string IdPaciente { get; set; }

        [Required(ErrorMessage = "Fecha de cita requerida")]
        [Display(Name = "Fecha de Cita")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public string Fecha { get; set; }

        [Required(ErrorMessage = "Hora de cita requerida")]
        [Display(Name = "Hora de Cita")]
        public string Hora { get; set; }
    }
}