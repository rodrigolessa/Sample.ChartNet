using System;
using System.Collections.Generic;

namespace Sample.ChartNet.Dominio.Entities
{
    public partial class Tarefa : EntityBase
    {
        public Nullable<Int32> Id { get; set; }
        public int IdUsuario { get; set; }
        public string Descricao { get; set; }
        public Nullable<Boolean> Executada { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
