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
        Luz220 l220;
        Led led;
        Temperatura temp;
        Webcam web;

        public Controle()
        {
            InitializeComponent();

            //Instâncias de objetos
            l220 = new Luz220(rtxtOut);
            led = new Led(rtxtOut);
            temp = new Temperatura(chart);
            web = new Webcam(rtxtOut);
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
