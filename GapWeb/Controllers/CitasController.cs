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
        // GET: Citas
        public ActionResult Index(string id)
        {
            return View(new Cita());
        }

        // GET: Citas/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Citas/Delete/5
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
