using GapWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace GapWeb.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public async Task<ActionResult> Index()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52052");
            string response = await client.GetStringAsync("/api/Pacientes");
            var serializer = new JavaScriptSerializer();
            IEnumerable<Paciente> paciente =
            serializer.Deserialize<IEnumerable<Paciente>>(response);
            return View(paciente);
        }

        // GET: Paciente/Details/5      
        public ActionResult Details(string id)
        {
            return RedirectToAction("Index", "Citas", new { @id = id, @hasError = false });
        }

        // GET: Paciente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Paciente/Create
        [HttpPost]
        public async Task<ActionResult> Create(Paciente paciente)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52052");
            HttpContent content = new ObjectContent<Paciente>(
            paciente, new JsonMediaTypeFormatter());
            HttpResponseMessage response =
            await client.PostAsync("/api/Pacientes", content);
            if (response.StatusCode.ToString().Equals("Created"))
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = String.Format("Paciente con documento No {0} ya existe, favor intentar nuevamente.", paciente.IdPaciente);
                return View(paciente);
            }
            
        }

        // GET: Paciente/Edit/5
        public ActionResult Edit(string id)
        {
            return RedirectToAction("Create", "Citas", new { @id = id });
        }

        // POST: Paciente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Paciente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Paciente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
