using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Common;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using Sample.ChartNet.Infraestrutura.Persistencia.UnitOfWork;
using Sample.ChartNet.Dominio.Entities;

namespace Sample.ChartNet.Infraestrutura.Persistencia.Teste.Initializers
{
    public class MainUnitOfWorkInitializer : DropCreateDatabaseAlways<MainUnitOfWork>
    {
        private const string _QUERY_IMPORTACAO_USUARIO = "insert into {kadastro}.dbo.usuario(Login, Senha, Email, Status) VALUES ('TesteExcluirUsuario', '123', 'contato@rodrigolessa.com', 'A');";

        protected override void Seed(MainUnitOfWork unitOfWork)
        {
            string queryImportacaoUsuario = _QUERY_IMPORTACAO_USUARIO.Replace("{kadastro}", "kadastro_teste");

            unitOfWork.ExecuteCommand(queryImportacaoUsuario);
        }
    }
}