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
using Sample.ChartNet.Aplicacao.DTO;

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

            var retorno = new GoogleChartDTO();
            retorno.cols = new List<GoogleChartColunaDTO>();
            retorno.rows = new List<GoogleChartLinhaDTO>();

            retorno.cols.Add(new GoogleChartColunaDTO() { id = "", label = "Nome", pattern = "", type = "string" });
            retorno.cols.Add(new GoogleChartColunaDTO() { id = "", label = "Depositos", pattern = "", type = "number" });
            retorno.cols.Add(new GoogleChartColunaDTO() { id = "", label = "Codigo", pattern = "", type = "string" });

            foreach (TarefaDTO item in tarefas)
            {
                var linhaC = new List<GoogleChartLinhaCDTO>();

                linhaC.Add(new GoogleChartLinhaCDTO() { v = item.Usuario.Login });
                linhaC.Add(new GoogleChartLinhaCDTO() { v = item.Id });
                linhaC.Add(new GoogleChartLinhaCDTO() { v = item.IdUsuario });

                retorno.rows.Add(new GoogleChartLinhaDTO() { c = linhaC });
            }

            return Json(tarefas);
        }

        public ActionResult getGrafico()
        {
           // var myChart = new System.Web.Helpers.Chart(width: 800, height: 400)
           //.AddTitle("Rank de Depósitos em 2010")
           //.AddSeries(
           //    name: "RankDepositos",
           //    chartType: "Doughnut",
           //    axisLabel: "PERCENT{P1}",
           //    markerStep: 1,
           //    legend: "Depósitos por Titulares",
           //    xValue: new[] { "QUALCOMM INCORPORATED (US)", "MICROSOFT CORPORATION (US)", "NOVARTIS AG (CH)", "3M INNOVATIVE PROPERTIES COMPANY (US)", "JOHNSON & JOHNSON (US)", "BASF AKTIENGESELLSCHAFT (DE)", "XEROX CORPORATION (US)", "THE PROCTER & GAMBLE COMPANY (US)", "THE GOODYEAR TIRE & RUBBER COMPANY (US)", "THOMSON LICENSING (FR)" },
           //    yValues: new[] { 266, 265, 187, 160, 152, 80, 85, 50, 30, 20 })
           //.Write();

            return null;
        }

        #endregion

        //
        // GET: /Home/

        public ActionResult Index()
        {
            //System.Web.UI.DataVisualization.Charting.Chart chart1 = new System.Web.UI.DataVisualization.Charting.Chart();
            //chart1.Width = 412;
            //chart1.Height = 296;
            //chart1.RenderType = System.Web.UI.DataVisualization.Charting.RenderType.ImageTag;
            //chart1.ImageLocation = "TempImages\\ChartPic" + Guid.NewGuid() + ".png";

            //ViewBag.Message = "Chart Helper";

            return View();
        }
    }
}
