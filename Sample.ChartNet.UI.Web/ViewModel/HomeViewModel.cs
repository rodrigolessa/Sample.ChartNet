using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sample.ChartNet.Dominio.Entities;

namespace Sample.ChartNet.UI.Web.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        public HomeViewModel()
            : base()
        {
        }

        public Usuario UsuarioLogado { get; set; }
        public List<Tarefa> Tarefas { get; set; }
    }
}