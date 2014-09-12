using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Sample.ChartNet.Infraestrutura.Persistencia.UnitOfWork;

namespace Sample.ChartNet.Infraestrutura.Persistencia.Teste.Initializers
{
    [SetUpFixture]
    public class AssemblyTestsInitialize
    {
        [TestFixtureSetUp()]
        public static void RebuildUnitOfWork(TestContext context)
        {
            //Define o padrão para inicialização do MainBCUnitOfWork
            Database.SetInitializer<MainUnitOfWork>(new MainUnitOfWorkInitializer());
        }
    }
}
