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
        private RichTextBox rtxtOut;

        public Luz220(RichTextBox rtxt, MqttClient client)
        {
            rtxtOut = rtxt;
            var x = rtxtOut.Handle;
            this.client = client;
        }

        public bool publishLigar()
        {
            try
            {
                client.Publish("luz220", Encoding.UTF8.GetBytes("ON"));
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
                client.Publish("luz220", Encoding.UTF8.GetBytes("OFF"));
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void update(string topico, string mensagem)
        {
            rtxtOut.Invoke((MethodInvoker)(() => rtxtOut.Text += "\n " + topico + " - " + mensagem));
        }
    }
}
