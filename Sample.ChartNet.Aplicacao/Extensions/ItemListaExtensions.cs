using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample.ChartNet.Dominio.Entities.Enum;
using Sample.ChartNet.Dominio.Model;
using Sample.ChartNet.Aplicacao.DTO;

namespace Sample.ChartNet.Aplicacao.Extensions
{
    public static class ItemListaExtensions
    {
        public static List<ItemListaDTO> ToItemListaDTO(this List<ItemListaModel> lista)
        {
            return lista.Select(x => x.ToItemListaDTO()).ToList();
        }

        public static ItemListaDTO ToItemListaDTO(this ItemListaModel item)
        {
            return new ItemListaDTO()
            {
                Id = item.Id,
                Descricao = item.Descricao
            };
        }
    }
}
