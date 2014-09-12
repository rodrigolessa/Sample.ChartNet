using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.ChartNet.Aplicacao.DTO;
using Sample.ChartNet.Aplicacao.Extensions;
using Sample.ChartNet.Infraestrutura.Comuns;
using Sample.ChartNet.Dominio.Entities;
using Sample.ChartNet.Dominio.Repositories;
using Sample.ChartNet.Dominio.Services;

namespace Sample.ChartNet.Aplicacao
{
    public class TarefaAppService : ITarefaAppService
    {
        #region Atributos

        private ITarefaRepository _tarefaRepository = null;
        private ITarefaService _tarefaService = null;

        #endregion

        #region Construtor

        public TarefaAppService(ITarefaRepository tarefaRepository, ITarefaService tarefaService)
        {
            _tarefaRepository = tarefaRepository;
            _tarefaService = tarefaService;
        }

        #endregion

        #region IUsuarioAppService membros

        public List<TarefaDTO> Obter()
        {
            return _tarefaService.Obter().ToTarefaDTO();
        }

        public List<TarefaDTO> Obter(string login)
        {
            return _tarefaService.Obter(login).ToTarefaDTO();
        }

        public BusinessResponse<bool> Salvar(TarefaDTO item)
        {
            return _tarefaService.Salvar(item.ToUsuario());
        }

        public BusinessResponse<bool> Excluir(int id)
        {
            return _tarefaService.Excluir(id);
        }

        public BusinessResponse<bool> Executar(int id)
        {
            return _tarefaService.Executar(id);
        }

        #endregion
    }
}
