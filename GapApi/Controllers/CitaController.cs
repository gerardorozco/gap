using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GapApi.Models;

namespace GapApi.Controllers
{
    public class CitaController : ApiController
    {

        GapDataClassesDataContext context = new GapDataClassesDataContext();

        // GET: api/Cita
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cita/5
        public IEnumerable<CitaModel> Get(string id)
        {
            var citas = from x in context.Cita.Where(c => c.IdPaciente == id)
                        join y in context.Paciente on x.IdPaciente equals y.IdPaciente
                        join z in context.TipoCita on x.TipoCita equals z.IdTipoCita
                        select new CitaModel() { IdCita = x.IdCita, TipoCita = z.TipoCita1, Paciente = y.NombrePaciente, Hora = x.Hora, Fecha = x.Fecha};

            List<CitaModel> citaList = new List<CitaModel>();

            foreach (var item in citas)
            {
                CitaModel citamodel = new CitaModel();
                citamodel.IdCita = item.IdCita;
                citamodel.TipoCita = item.TipoCita;
                citamodel.Paciente = item.Paciente;
                citamodel.Hora = item.Hora;
                citamodel.Fecha = item.Fecha;
                citaList.Add(citamodel);
            }

            return citaList;
        }

        // POST: api/Cita
        public HttpResponseMessage Post([FromBody]Cita value)
        {
            string result = String.Empty;
            try
            {
                context.Cita.InsertOnSubmit(value);
                context.SubmitChanges();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed);
            }

            return Request.CreateResponse(HttpStatusCode.Created, result);

        }

        // PUT: api/Cita/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cita/5
        public void Delete(int id)
        {
            var cita = from c in context.Cita where c.IdCita == id select c;

        }
    }
}
