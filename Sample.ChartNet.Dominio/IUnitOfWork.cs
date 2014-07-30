using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.ChartNet.Dominio
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
        void CommitAndRefreshChanges();
        void RollbackChanges();
    }
}
