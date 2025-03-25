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
        private RichTextBox rtxtOut;
        public Webcam(RichTextBox rtxt, MqttClient client)
        {
            rtxtOut = rtxt;
            var x = rtxtOut.Handle;
            this.client = client;
        }
        public void update(string topico, string mensagem)
        {
            rtxtOut.Invoke((MethodInvoker)(() => rtxtOut.Text += "\n " + topico + " " + mensagem));
        }
        public bool publishEsq()
        {
            try
            {
                client.Publish("motor", Encoding.UTF8.GetBytes("left"));
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
                client.Publish("motor", Encoding.UTF8.GetBytes("right"));
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
                client.Publish("motor", Encoding.UTF8.GetBytes("up"));
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
                client.Publish("motor", Encoding.UTF8.GetBytes("down"));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
