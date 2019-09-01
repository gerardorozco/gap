using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GapApi.Models;

namespace GapApi.Controllers
{
    public class PacientesController : ApiController
    {
        GapDataClassesDataContext context = new GapDataClassesDataContext();

        // GET: api/Pacientes
        public IEnumerable<Paciente> Get()
        {
            return context.Paciente;
        }

        // GET: api/Pacientes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pacientes
        public HttpResponseMessage Post([FromBody]Paciente value)
        {
            string result = String.Empty;
            try
            {
                context.Paciente.InsertOnSubmit(value);
                context.SubmitChanges();             

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed);
            }
            return Request.CreateResponse(HttpStatusCode.Created, result);

        }

        // PUT: api/Pacientes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pacientes/5
        public void Delete(int id)
        {
        }
    }
}
