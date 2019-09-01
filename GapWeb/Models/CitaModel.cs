using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GapWeb.Models
{
    public class CitaModel
    {
        public int IdCita { get; set; }
        public string TipoCita { get; set; }
        public string Paciente { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
    }
}