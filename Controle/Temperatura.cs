using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt;
using System.Windows.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace Controle
{
    class Temperatura
    {
        private MqttClient client;
        private Chart chart;
        private int lastX = 0;
        public Temperatura(Chart grafico, MqttClient client)
        {
            chart = grafico;
            var x = chart.Handle;
            this.client = client;

            InicializarGrafico();
        }
        //Atualizar o gráfico
        public void update(string mensagem1, string mensagem2)
        {
            //Realiza o TryParse
            if (double.TryParse(mensagem1.Replace(".", ","), out double temperature)
                && double.TryParse(mensagem2.Replace(".", ","), out double humidade))
            {
                lastX++;
                //Atualiza a temperatura
                chart.Invoke((MethodInvoker)(() => Atualizar(temperature, humidade)));
            }

        }
        //Inicializa o Gráfico
        private void InicializarGrafico()
        {
            //Limpa o Gráfico
            chart.Series.Clear();
            var series = new Series("Temperatura")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.Red
            };
            var series2 = new Series("Humidade")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.Blue
            };
            chart.Series.Add(series);
            chart.Series.Add(series2);
            chart.ChartAreas[0].AxisX.Title = "Tempo";
            chart.ChartAreas[0].AxisY.Title = "Temperatura (°C)/Humiade(0 - 100)";
        }
        //Atualiza os dados do gráfico
        private void Atualizar(double Temperatura, double Humidade)
        {
            var series = chart.Series[0];
            var series2 = chart.Series[1];
            // Atualizar escala se for tiver mais que dez
            if (series.Points.Count > 10)
            {
                // Mover o gráfico por uma unidade
                chart.ChartAreas[0].AxisX.Minimum = lastX - 10; // o novo mínimo
                chart.ChartAreas[0].AxisX.Maximum = lastX; // máximo
            }

            // Adicionar temperatura
            series.Points.AddY(Temperatura);
            series2.Points.AddY(Humidade);

            // Atualizar o gráfico
            chart.Invalidate();
        }
    }
}
