////////////////////////////////////////////////////////////////////////////////////////
// This is a simple *viewmodel* - JavaScript that defines the data and behavior of your UI


////////////////////////////////////////////////////////////////////////////////////////
// Função principal para View
function HomeIndexViewModel() {

    var self = this;

    alert("bind");

    var graficoTotais = new Graficos();

    graficoTotais.URL = '/Home/ObterRank';
    graficoTotais.Parametros = {};
    graficoTotais.Titulo = 'Rank de Tarefas por Usuários';
    graficoTotais.Gerar();
}