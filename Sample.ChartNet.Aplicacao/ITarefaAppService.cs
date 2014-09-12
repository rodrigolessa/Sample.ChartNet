using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample.ChartNet.Infraestrutura.Comuns;
using Sample.ChartNet.Aplicacao.DTO;
using Sample.ChartNet.Dominio.Entities;

namespace Sample.ChartNet.Aplicacao
{
    public interface ITarefaAppService
    {
        List<TarefaDTO> Obter();
        List<TarefaDTO> Obter(string login);
        BusinessResponse<Boolean> Salvar(TarefaDTO item);
        BusinessResponse<Boolean> Excluir(Int32 id);
        BusinessResponse<Boolean> Executar(Int32 id);
    }
}
