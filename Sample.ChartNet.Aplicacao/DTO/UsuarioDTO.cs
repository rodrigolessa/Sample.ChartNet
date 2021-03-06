﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample.ChartNet.Aplicacao.DTO
{
    public class UsuarioDTO
    {
        public Nullable<Int32> Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string DescricaoDoStatus { get; set; }
        public bool EhPrimeiroAcesso { get; set; }
    }
}