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
    class Led
    {
        private MqttClient client;
        private string clientId;
        private RichTextBox rtxtOut;
        public Led(RichTextBox rtxt)
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
            
            string[] topicos = new string[] { "led1", "led2", "led3", "led4" };

            
            byte[] qosLevels = new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
                                            MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
                                            MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
                                            MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE };

            client.Subscribe(topicos, qosLevels);            
        }
        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            // handle message received
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);
            rtxtOut.Invoke((MethodInvoker)(() => rtxtOut.Text += "\n" + ReceivedMessage));
        }
        public bool publishLigar(string num)
        {
            try
            {
                switch (num)
                {
                    case "1":
                        client.Publish("led1", Encoding.UTF8.GetBytes("ON"));
                        break;
                    case "2":
                        client.Publish("led2", Encoding.UTF8.GetBytes("ON"));
                        break;
                    case "3":
                        client.Publish("led3", Encoding.UTF8.GetBytes("ON"));
                        break;
                    case "4":
                        client.Publish("led4", Encoding.UTF8.GetBytes("ON"));
                        break;
                    default:
                        break;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool publishDesligar(string num)
        {
            try
            {
                switch (num)
                {
                    case "1":
                        client.Publish("led1", Encoding.UTF8.GetBytes("OFF"));
                        break;
                    case "2":
                        client.Publish("led2", Encoding.UTF8.GetBytes("OFF"));
                        break;
                    case "3":
                        client.Publish("led3", Encoding.UTF8.GetBytes("OFF"));
                        break;
                    case "4":
                        client.Publish("led4", Encoding.UTF8.GetBytes("OFF"));
                        break;
                    default:
                        break;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
