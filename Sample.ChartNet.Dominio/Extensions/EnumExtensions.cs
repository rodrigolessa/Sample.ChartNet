using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using Sample.ChartNet.Infraestrutura.Comuns.Extensions;
using Sample.ChartNet.Dominio.Model;
using Sample.ChartNet.Dominio.Entities;
using Sample.ChartNet.Dominio.Entities.Enum;

namespace Sample.ChartNet.Dominio.Extensions
{
    public static class EnumExtensions
    {
        public static List<ItemListaModel> ToItemListaModel(this Type enumerador)
        {
            if (enumerador.BaseType.Name != "Enum")
                return null;

            var lista = enumerador.ToDicionarioEnum();

            return (from o in lista
                    select new ItemListaModel(Convert.ToInt64(o.Key), o.Value)).ToList();
        }

        public static ItemListaModel ToItemListaModel(this System.Enum value)
        {
            ItemListaModel model = new ItemListaModel();
            model.Id = Convert.ToInt64(value);
            model.Descricao = TypeExtensions.ObterDescricao(value);

            return model;
        }
    }
}
