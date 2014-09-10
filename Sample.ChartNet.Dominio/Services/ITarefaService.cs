using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample.ChartNet.Infraestrutura.Comuns;
using Sample.ChartNet.Dominio.Entities;
using Sample.ChartNet.Dominio.Entities.Enum;
using Sample.ChartNet.Dominio.Model;

namespace Sample.ChartNet.Dominio.Services
{
    public interface ITarefaService
    {
        List<Tarefa> Obter(string login);
        BusinessResponse<Boolean> Salvar(Tarefa item);
        BusinessResponse<Boolean> Excluir(Int32 id);
        BusinessResponse<Boolean> Executar(Int32 id);
    }
}
