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
    public partial class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        #region Construtor

        /// <summary>
        /// Cria uma Nova Instância
        /// </summary>
        /// <param name="unitOfWork">Associado ao Unit Of Work</param>
        public UsuarioRepository(MainUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #endregion

        public IEnumerable<Usuario> ObterPeloLogin(string login)
        {
            return this.GetFiltered(x => x.Login == login);
        }
    }
}
