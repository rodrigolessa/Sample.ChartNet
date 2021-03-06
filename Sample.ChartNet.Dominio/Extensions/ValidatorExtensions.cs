﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.ChartNet.Infraestrutura.Comuns.Validator;
using Sample.ChartNet.Dominio.Entities;

namespace Sample.ChartNet.Dominio.Extensions
{
    public static class ValidatorExtensions
    {
        public delegate void ExecutarSeValido();

        // Extension para executar a validação de uma entidade
        public static IEnumerable<string> FazerSeForValido<T>(this EntityBase entidadeASerValidada, ExecutarSeValido executarSeValido) where T : EntityBase
        {
            var validador = EntityValidatorFactory.CreateValidator();

            if (validador.EhValido((T)entidadeASerValidada))
            {
                executarSeValido();
                return null;
            }

            return validador.ObterMensagensDeErro((T)entidadeASerValidada);
        }

        // Extension para uma lista de strings
        public static bool ExistemErros(this IEnumerable<string> erros)
        {
            return erros != null && erros.Count() > 0;
        }
    }
}
