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
        private string clientId;
        private Chart chart;
        private int lastX = 0;
        public Temperatura(Chart grafico)
        {
            chart = grafico;
            var x = chart.Handle;
            //Mqtt
            string BrokerAddress = "89.154.162.243";
            string user = "profmiguel";
            string pass = "Esas2024";

            client = new MqttClient(BrokerAddress);
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            clientId = Guid.NewGuid().ToString();
            client.Connect(clientId, user, pass);

            client.Subscribe(new string[] { "Temperatura" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            InicializarGrafico();
        }
        //Atualizar o gráfico
        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            //Transformar em string
            var mensagem = Encoding.UTF8.GetString(e.Message);

            //Realiza o TryParse
            if (double.TryParse(mensagem, out double temperature))
            {
                //Atualiza a temperatura
                chart.Invoke((MethodInvoker)(() => Atualizar(temperature)));
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
                BorderWidth = 2
            };
            chart.Series.Add(series);
            chart.ChartAreas[0].AxisX.Title = "Tempo";
            chart.ChartAreas[0].AxisY.Title = "Temperatura (°C)";
        }
        //Atualiza os dados do gráfico
        private void Atualizar(double Temperatura)
        {
            var series = chart.Series[0];

            lastX++;
            // Atualizar escala se for tiver mais que dez
            if (series.Points.Count > 10)
            {
                // Mover o gráfico por uma unidade
                chart.ChartAreas[0].AxisX.Minimum = lastX - 10; // o novo mínimo
                chart.ChartAreas[0].AxisX.Maximum = lastX; // máximo
            }

            // Adicionar temperatura
            series.Points.AddY(Temperatura);

            // Atualizar o gráfico
            chart.Invalidate();
        }
    }
}
