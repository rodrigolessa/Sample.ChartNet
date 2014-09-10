using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample.ChartNet.Infraestrutura.Comuns;
using Sample.ChartNet.Aplicacao.DTO;
using Sample.ChartNet.Dominio.Entities;

namespace Sample.ChartNet.Aplicacao
{
    public interface IUsuarioAppService
    {
        BusinessResponse<Boolean> Autenticar(string login, string senha);
        UsuarioDTO Obter(string login);
        UsuarioDTO Obter(int id);
        List<UsuarioDTO> Obter();
        BusinessResponse<Boolean> Salvar(UsuarioDTO item);
        BusinessResponse<Boolean> Excluir(int id);

        List<ItemListaDTO> ObterPerfilDeAcesso();
    }
}