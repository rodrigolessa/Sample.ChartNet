using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Sample.ChartNet.Dominio;
using Sample.ChartNet.Dominio.Entities;
using Sample.ChartNet.Infraestrutura.Persistencia.UnitOfWork.Mapping;

namespace Sample.ChartNet.Infraestrutura.Persistencia.UnitOfWork
{
    public partial class MainUnitOfWork : DbContext, IQueryableUnitOfWork
    {
        static MainUnitOfWork()
        {
            Database.SetInitializer<MainUnitOfWork>(null);
        }

        public MainUnitOfWork()
            : base("Name=kadastroContext")
        {
        }

        public DbSet<TitularAno> TitularAnoes { get; set; }

        #region DbContext Overrides

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TitularAnoMap());
        }

        #endregion

        #region IQueryableUnitOfWork Members

        public IDbSet<TEntity> CreateSet<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void Attach<TEntity>(TEntity item) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void SetModified<TEntity>(TEntity item) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }

        public void CommitAndRefreshChanges()
        {
            throw new NotImplementedException();
        }

        public void RollbackChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
