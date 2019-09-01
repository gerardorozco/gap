using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GapApi.Models;

namespace GapApi.Controllers
{  

    public class TipoCitasController : ApiController
    {

        GapDataClassesDataContext context = new GapDataClassesDataContext();

        // GET: api/TipoCitas
        public IEnumerable<TipoCita> Get()
        {
            return context.TipoCita;
        }

        // GET: api/TipoCitas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TipoCitas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TipoCitas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TipoCitas/5
        public void Delete(int id)
        {
        }
    }
}
