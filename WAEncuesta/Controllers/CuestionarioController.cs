using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using WAEncuesta.Models;
using Microsoft.EntityFrameworkCore;

namespace WAEncuesta.Controllers
{
    public class CuestionarioController : Controller
    {
        private readonly EncuestaContext _con;

        public CuestionarioController( EncuestaContext context )
        {
            _con = context;
        }

        // GET: CuestionarioController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CuestionarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CuestionarioController/Create
        public ActionResult Add()
        {
            return View();
        }

        // POST: CuestionarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add (TbCuestionario CuestionarioRequest)
        {
            try
            {
                var quest = new TbCuestionario()
                {
                    Preguntauno = CuestionarioRequest.Preguntauno,
                    Preguntados = CuestionarioRequest.Preguntados,
                    Preguntatres = CuestionarioRequest.Preguntatres,
                    Preguntacuatro = CuestionarioRequest.Preguntacuatro,
                    Preguntacinco = CuestionarioRequest.Preguntacinco,
                    Preguntaseis = CuestionarioRequest.Preguntaseis,
                    Preguntasiete = CuestionarioRequest.Preguntasiete,
                    Preguntaocho = CuestionarioRequest.Preguntaocho,
                    Preguntanueve = CuestionarioRequest.Preguntanueve,
                    Preguntadiez = CuestionarioRequest.Preguntadiez
                };

                await _con.TbCuestionarios.AddAsync(quest);
                await _con.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CuestionarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CuestionarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CuestionarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CuestionarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
