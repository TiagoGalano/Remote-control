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
    class Luz220
    {

        private MqttClient client;
        private string clientId;
        private RichTextBox rtxtOut;

        public Luz220(RichTextBox rtxt)
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

            client.Subscribe(new string[] { "Luz220" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
        }

        public bool publishLigar()
        {
            try
            {
                client.Publish("Luz220", Encoding.UTF8.GetBytes("ON"));
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool publishDesligar()
        {
            try
            {
                client.Publish("Luz220", Encoding.UTF8.GetBytes("OFF"));
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            // handle message received
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);
            rtxtOut.Invoke((MethodInvoker)(() => rtxtOut.Text += "\n" + ReceivedMessage));
        }
    }
}
