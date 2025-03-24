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

namespace Controle
{
    class Webcam
    {
        private MqttClient client;
        private string clientId;
        private RichTextBox rtxtOut;
        public Webcam(RichTextBox rtxt)
        {
            rtxtOut = rtxt;
            var x = rtxtOut.Handle;
            string BrokerAddress = "89.154.162.243";
            string user = "profmiguel";
            string pass = "Esas2024";

            client = new MqttClient(BrokerAddress);

            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            clientId = Guid.NewGuid().ToString();
            client.Connect(clientId, user, pass);

            client.Subscribe(new string[] { "Webcam" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
        }
        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            // handle message received
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);
            rtxtOut.Invoke((MethodInvoker)(() => rtxtOut.Text += "\n" + ReceivedMessage));
        }
        public bool publishEsq()
        {
            try
            {
                client.Publish("Webcam", Encoding.UTF8.GetBytes("ESQ"));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool publishDir()
        {
            try
            {
                client.Publish("Webcam", Encoding.UTF8.GetBytes("DIR"));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool publishCima()
        {
            try
            {
                client.Publish("Webcam", Encoding.UTF8.GetBytes("CIM"));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool publishBaixo()
        {
            try
            {
                client.Publish("Webcam", Encoding.UTF8.GetBytes("BAI"));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
