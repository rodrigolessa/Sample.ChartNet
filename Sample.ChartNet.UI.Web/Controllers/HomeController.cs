using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample.ChartNet.Infraestrutura.Comuns;
using Sample.ChartNet.Infraestrutura.Persistencia.Repositories;
using Sample.ChartNet.Infraestrutura.Persistencia.UnitOfWork;
using Sample.ChartNet.Dominio.Services;
using Sample.ChartNet.Aplicacao;

namespace Sample.ChartNet.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Atributos

        private readonly IUsuarioAppService _usuarioAppService;
        private readonly ITarefaAppService _tarefaAppService;

        #endregion

        #region Construtor

        public HomeController()
        {
            //context
            var unit = new MainUnitOfWork();

            //repositories
            var usuarioRepository = new UsuarioRepository(unit);
            //var pontoRepository = new PontoRepository(unit);
            //var intervaloRepository = new IntervaloRepository(unit);
            var tarefaRepository = new TarefaRepository(unit);

            //services
            var usuarioService = new UsuarioService(usuarioRepository);
            var tarefaService = new TarefaService(tarefaRepository);
            //var pontoRepository = new PontoService(pontoRepository, intervaloRepository);

            //applications
            _usuarioAppService = new UsuarioAppService(usuarioRepository, usuarioService);
            _tarefaAppService = new TarefaAppService(tarefaRepository, tarefaService);
        }

        #endregion

        #region Operações de Tarefas

        public JsonResult ObterRank()
        {
            var tarefas = _tarefaAppService.Obter();

            return Json(tarefas);
        }

        #endregion

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

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

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

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
