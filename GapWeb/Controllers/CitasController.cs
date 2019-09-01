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
    public class CitasController : Controller
    {
        // GET: Paciente/Details/5      
        public ActionResult Return()
        {
            return RedirectToAction("Index", "Paciente");
        }

        // GET: Citas
        public async Task<ActionResult> Index(string id)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52052");

            string response = await client.GetStringAsync("/api/Cita/" + id);
            var serializer = new JavaScriptSerializer();
            IEnumerable<CitaModel> tipoCitas =
            serializer.Deserialize<IEnumerable<CitaModel>>(response);
            ViewBag.Paciente = id;

            return View(tipoCitas);

        }

        // GET: Citas/Details/5
        public ActionResult Details(string id)
        {
            return RedirectToAction("Index", "Citas", new { @id = id });
        }

        // GET: Citas/Create
        public async Task<ActionResult> Create(string id)
        {
            Cita cita = new Cita();
            cita.IdPaciente = id;

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52052");
            string response = await client.GetStringAsync("/api/TipoCitas");
            var serializer = new JavaScriptSerializer();
            IEnumerable<TipoCita> tipoCitas =
            serializer.Deserialize<IEnumerable<TipoCita>>(response);

            List<SelectListItem> tipos = new List<SelectListItem>();
            foreach (var item in tipoCitas)
            {
                tipos.Add(new SelectListItem { Text = item.TipoCita1, Value = item.IdTipoCita.ToString() });
            }
            ViewBag.ddlTipoCitas = tipos;

            return View(cita);
        }

        // POST: Citas/Create
        [HttpPost]
        public async Task<ActionResult> Create(Cita cita)
        {

            if (ModelState.IsValid)
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:52052");
                HttpContent content = new ObjectContent<Cita>(
                cita, new JsonMediaTypeFormatter());
                HttpResponseMessage response =
                await client.PostAsync("/api/Cita", content);
                if (response.StatusCode.ToString().Equals("Created"))
                {
                    return RedirectToAction("Index", "Paciente");
                }
                else
                {

                    client = new HttpClient();
                    client.BaseAddress = new Uri("http://localhost:52052");
                    string resp = await client.GetStringAsync("/api/TipoCitas");
                    var serializer = new JavaScriptSerializer();
                    IEnumerable<TipoCita> tipoCitas =
                    serializer.Deserialize<IEnumerable<TipoCita>>(resp);

                    List<SelectListItem> tipos = new List<SelectListItem>();
                    foreach (var item in tipoCitas)
                    {
                        tipos.Add(new SelectListItem { Text = item.TipoCita1, Value = item.IdTipoCita.ToString() });
                    }
                    ViewBag.ddlTipoCitas = tipos;
                    ViewBag.ErrorMessage = String.Format("Paciente con documento No {0} ya tiene cita asignada para el dia {1}.", cita.IdPaciente, cita.Fecha);

                    return View(cita);
                }
            }
            else
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:52052");
                string resp = await client.GetStringAsync("/api/TipoCitas");
                var serializer = new JavaScriptSerializer();
                IEnumerable<TipoCita> tipoCitas =
                serializer.Deserialize<IEnumerable<TipoCita>>(resp);

                List<SelectListItem> tipos = new List<SelectListItem>();
                foreach (var item in tipoCitas)
                {
                    tipos.Add(new SelectListItem { Text = item.TipoCita1, Value = item.IdTipoCita.ToString() });
                }
                ViewBag.ddlTipoCitas = tipos;

                return View(cita);
            }

        }

        // GET: Citas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Citas/Edit/5
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

        // GET: Citas/Delete/5
        public async Task<ActionResult> Delete(int id, string paciente)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:52052");
                HttpResponseMessage response =
                await client.DeleteAsync("/api/Cita/" + id);
                response.EnsureSuccessStatusCode();

                return RedirectToAction("Index", new { id = paciente });
            }
            catch
            {
                return RedirectToAction("Index", new { id = paciente });
            }
        }

        // POST: Citas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            return View();
        }
    }
}
