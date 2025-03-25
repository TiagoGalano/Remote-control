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
    public partial class Controle : Form
    {
        private MqttClient client;
        private string clientId;
        Luz220 l220;
        Led led;
        Temperatura temp;
        Webcam web;
        private string[] tempHum = {"", ""};

        public Controle()
        {
            InitializeComponent();

            string BrokerAddress = "89.154.162.243";
            string user = "profmiguel";
            string pass = "Esas2024";

            client = new MqttClient(BrokerAddress);

            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            clientId = Guid.NewGuid().ToString();
            client.Connect(clientId, user, pass);

            string[] topicos = new string[] { "led1", "led2", "led3", "led4", "motor", "temperatura", "luz220", "humidade" };


            byte[] qosLevels = new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
                                            MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
                                            MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
                                            MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
                                            MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
                                            MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
                                            MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
                                            MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE};

            client.Subscribe(topicos, qosLevels);

            //Instâncias de objetos
            l220 = new Luz220(rtxtOut, client);
            led = new Led(rtxtOut, client);
            temp = new Temperatura(chart, client);
            web = new Webcam(rtxtOut, client);
        }

        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            //Transformar em string
            string mensagem = Encoding.UTF8.GetString(e.Message);
            switch (e.Topic)
            {
                case "temperatura":
                    tempHum[0] = mensagem;
                    break;
                case "humidade":
                    tempHum[1] = mensagem;
                    break;
                case "motor":
                    web.update(e.Topic, mensagem);
                    break;
                case "luz220":
                    l220.update(e.Topic, mensagem);
                    break;
                default:
                    led.update(e.Topic, mensagem);
                    break;
            }
            if (tempHum[0] != "" && tempHum[1] != "")
            {
                temp.update(tempHum[0], tempHum[1]);
                tempHum[0] = "";
                tempHum[1] = "";
            }

        }
        private void btnON220_Click(object sender, EventArgs e)
        {
            if (!l220.publishLigar())
            {
                MessageBox.Show("Deu erro", "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnOFF220_Click(object sender, EventArgs e)
        {
            if (!l220.publishDesligar())
            {
                MessageBox.Show("Deu erro", "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnLed1ON_Click(object sender, EventArgs e)
        {
            led.publishLigar("1");
        }

        private void btnLed1OFF_Click(object sender, EventArgs e)
        {
            led.publishDesligar("1");
        }

        private void btnLed2ON_Click(object sender, EventArgs e)
        {
            led.publishLigar("2");
        }

        private void btnLed2OFF_Click(object sender, EventArgs e)
        {
            led.publishDesligar("2");
        }

        private void btnLed3ON_Click(object sender, EventArgs e)
        {
            led.publishLigar("3");
        }

        private void btnLed3OFF_Click(object sender, EventArgs e)
        {
            led.publishDesligar("3");
        }

        private void btnLed4ON_Click(object sender, EventArgs e)
        {
            led.publishLigar("4");
        }

        private void btnLed4OFF_Click(object sender, EventArgs e)
        {
            led.publishDesligar("4");
        }

        private void btnEsq_Click(object sender, EventArgs e)
        {
            if (!web.publishEsq())
            {
                MessageBox.Show("Deu Erro", "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            if (!web.publishCima())
            {
                MessageBox.Show("Deu Erro", "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            if (!web.publishBaixo())
            {
                MessageBox.Show("Deu Erro", "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            if (!web.publishDir())
            {
                MessageBox.Show("Deu Erro", "Erro", MessageBoxButtons.OK);
            }
        }
    }
}
