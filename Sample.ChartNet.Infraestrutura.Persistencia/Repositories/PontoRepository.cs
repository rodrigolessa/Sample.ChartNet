using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample.ChartNet.Dominio;
using Sample.ChartNet.Dominio.Entities;
using Sample.ChartNet.Dominio.Repositories;
using Sample.ChartNet.Infraestrutura.Persistencia.UnitOfWork;

namespace Sample.ChartNet.Infraestrutura.Persistencia.Repositories
{
    public partial class PontoRepository : Repository<Ponto>, IPontoRepository
    {
        #region Construtor

        /// <summary>
        /// Cria uma Nova Instância
        /// </summary>
        /// <param name="unitOfWork">Associado ao Unit Of Work</param>
        public PontoRepository(MainUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #endregion
    }
}
