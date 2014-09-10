using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample.ChartNet.Dominio.Entities;
using Sample.ChartNet.Aplicacao.DTO;

namespace Sample.ChartNet.Aplicacao.Extensions
{
    public static class UsuarioExtensions
    {
        public static List<UsuarioDTO> ToUsuarioDTO(this List<Usuario> lista)
        {
            return lista.Select(x => x.ToUsuarioDTO()).ToList();
        }

        public static UsuarioDTO ToUsuarioDTO(this Usuario item)
        {
            return new UsuarioDTO()
            {
                Id = item.Id,
                Login = item.Login,
                Senha = item.Senha,
                Email = item.Email,
                Status = item.Status,
                DescricaoDoStatus = item.DescricaoDoStatus,
                EhPrimeiroAcesso = true
            };
        }

        public static Usuario ToUsuario(this UsuarioDTO item)
        {
            return new Usuario()
            {
                Id = item.Id,
                Login = item.Login,
                Senha = item.Senha,
                Email = item.Email,
                Status = item.Status
            };
        }
    }
}
