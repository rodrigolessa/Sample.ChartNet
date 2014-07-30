using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.ChartNet.Dominio;
using Sample.ChartNet.Dominio.Entities;
using Sample.ChartNet.Dominio.Repositories;
using Sample.ChartNet.Dominio.Services;

namespace Sample.ChartNet.Aplicacao
{
    public class TitularAnoAppService : ITitularAnoAppService
    {
        #region Atributos

        private ITitularAnoRepository _titularAnoRepository = null;
        private ITitularAnoService _titularAnoService = null;

        #endregion

        #region Construtor

        public TitularAnoAppService(ITitularAnoRepository titularAnoRepository, ITitularAnoService titularAnoService)
        {
            _titularAnoRepository = titularAnoRepository;
            _titularAnoService = titularAnoService;
        }

        #endregion

        #region ITitularAnoAppService membros
        #endregion
    }
}
