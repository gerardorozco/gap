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
        public string Get(int id)
        {
            return "value";
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
