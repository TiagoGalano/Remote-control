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
        private RichTextBox rtxtOut;
        public Led(RichTextBox rtxt, MqttClient client)
        {
            rtxtOut = rtxt;
            var x = rtxtOut.Handle;
            this.client = client;          
        }
        public void update(string topico, string mensagem)
        {
            rtxtOut.Invoke((MethodInvoker)(() => rtxtOut.Text += "\n "+ topico + " " + mensagem));
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
