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
    public interface IUsuarioService
    {
        BusinessResponse<Boolean> Autenticar(string login, string senha);
        Usuario ObterPeloLogin(string login);
        Usuario Obter(int id);
        List<Usuario> Obter();
        List<ItemListaModel> ObterPerfilDeAcesso();
        BusinessResponse<Boolean> Salvar(Usuario item);
        BusinessResponse<Boolean> Excluir(int id);
    }
}
