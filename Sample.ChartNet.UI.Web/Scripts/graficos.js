function Graficos() {

    this.URL = "/";
    this.Parametros = {};

    this.TipoGrafico = "Torta";
    this.Titulo = "";
    this.Largura = 800;
    this.Altura = 400;
    this.Eh3D = false;
    this.NomeDiv = "grafico1";
    this.FuncaoClick = "";

    this.Gerar = function () {

        // Inicia a API de gráficos do Google
        //google.load('visualization', '1.0', { 'packages': ['corechart'] });

        // Set a callback to run when the Google Visualization API is loaded.

        alert(this.Titulo);
        alert(this.URL);

        google.setOnLoadCallback(

            doAjx(this.URL, this.Parametros, function (resultadoJson) {

                alert(resultadoJson);

                var dadosGrafico = new google.visualization.DataTable(resultadoJson);

                // Set chart options
                var opcoes = {
                    title: this.Titulo,
                    width: this.Largura,
                    height: this.Altura,
                    is3D: this.Eh3D,
                    pieHole: 0.5,
                    pieStartAngle: 80,
                    slices: {
                        5: { color: 'LightGray' },
                        6: { color: 'DarkGray' },
                        7: { color: 'gray' },
                        8: { color: 'gray' },
                        9: { color: 'gray' }
                    }
                };

                function selectHandler() {
                    var selectedItem = objGrafico.getSelection()[0];
                    if (selectedItem) {
                        var topping = dadosGrafico.getValue(selectedItem.row, 2);
                        alert('Código da Fatia selecionada = ' + topping);
                    }
                }

                // Instantiate and draw our chart, passing in some options.
                var objGrafico = new google.visualization.PieChart(document.getElementById(this.NomeDiv));

                // Adiciona um evento de seleção dos valores do gráfico
                google.visualization.events.addListener(objGrafico, 'select', selectHandler);

                objGrafico.draw(dadosGrafico, opcoes);

            })

        );
    }
}