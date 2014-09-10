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

        public string NomeUsuario { get; set; }
        public List<Ponto> Pontos { get; set; }
    }
}