
namespace Controle
{
    partial class Controle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gBoxL220 = new System.Windows.Forms.GroupBox();
            this.btnOFF220 = new System.Windows.Forms.Button();
            this.btnON220 = new System.Windows.Forms.Button();
            this.gBoxLed = new System.Windows.Forms.GroupBox();
            this.lblLed4 = new System.Windows.Forms.Label();
            this.lblLed3 = new System.Windows.Forms.Label();
            this.btnLed4OFF = new System.Windows.Forms.Button();
            this.lblLed2 = new System.Windows.Forms.Label();
            this.btnLed4ON = new System.Windows.Forms.Button();
            this.btnLed3OFF = new System.Windows.Forms.Button();
            this.btnLed2OFF = new System.Windows.Forms.Button();
            this.btnLed3ON = new System.Windows.Forms.Button();
            this.btnLed2ON = new System.Windows.Forms.Button();
            this.lblLed1 = new System.Windows.Forms.Label();
            this.btnLed1OFF = new System.Windows.Forms.Button();
            this.btnLed1ON = new System.Windows.Forms.Button();
            this.gBoxTemp = new System.Windows.Forms.GroupBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rtxtOut = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBaixo = new System.Windows.Forms.Button();
            this.btnCima = new System.Windows.Forms.Button();
            this.btnDir = new System.Windows.Forms.Button();
            this.btnEsq = new System.Windows.Forms.Button();
            this.gBoxWebcam = new System.Windows.Forms.GroupBox();
            this.pBoxWeb = new System.Windows.Forms.PictureBox();
            this.gBoxL220.SuspendLayout();
            this.gBoxLed.SuspendLayout();
            this.gBoxTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gBoxWebcam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxWeb)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxL220
            // 
            this.gBoxL220.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gBoxL220.Controls.Add(this.btnOFF220);
            this.gBoxL220.Controls.Add(this.btnON220);
            this.gBoxL220.Location = new System.Drawing.Point(264, 93);
            this.gBoxL220.Name = "gBoxL220";
            this.gBoxL220.Size = new System.Drawing.Size(257, 57);
            this.gBoxL220.TabIndex = 0;
            this.gBoxL220.TabStop = false;
            this.gBoxL220.Text = "Luz 220";
            // 
            // btnOFF220
            // 
            this.btnOFF220.Location = new System.Drawing.Point(87, 19);
            this.btnOFF220.Name = "btnOFF220";
            this.btnOFF220.Size = new System.Drawing.Size(75, 23);
            this.btnOFF220.TabIndex = 2;
            this.btnOFF220.Text = "OFF";
            this.btnOFF220.UseVisualStyleBackColor = true;
            this.btnOFF220.Click += new System.EventHandler(this.btnOFF220_Click);
            // 
            // btnON220
            // 
            this.btnON220.Location = new System.Drawing.Point(6, 19);
            this.btnON220.Name = "btnON220";
            this.btnON220.Size = new System.Drawing.Size(75, 23);
            this.btnON220.TabIndex = 1;
            this.btnON220.Text = "ON";
            this.btnON220.UseVisualStyleBackColor = true;
            this.btnON220.Click += new System.EventHandler(this.btnON220_Click);
            // 
            // gBoxLed
            // 
            this.gBoxLed.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gBoxLed.Controls.Add(this.lblLed4);
            this.gBoxLed.Controls.Add(this.lblLed3);
            this.gBoxLed.Controls.Add(this.btnLed4OFF);
            this.gBoxLed.Controls.Add(this.lblLed2);
            this.gBoxLed.Controls.Add(this.btnLed4ON);
            this.gBoxLed.Controls.Add(this.btnLed3OFF);
            this.gBoxLed.Controls.Add(this.btnLed2OFF);
            this.gBoxLed.Controls.Add(this.btnLed3ON);
            this.gBoxLed.Controls.Add(this.btnLed2ON);
            this.gBoxLed.Controls.Add(this.lblLed1);
            this.gBoxLed.Controls.Add(this.btnLed1OFF);
            this.gBoxLed.Controls.Add(this.btnLed1ON);
            this.gBoxLed.Location = new System.Drawing.Point(12, 12);
            this.gBoxLed.Name = "gBoxLed";
            this.gBoxLed.Size = new System.Drawing.Size(246, 139);
            this.gBoxLed.TabIndex = 3;
            this.gBoxLed.TabStop = false;
            this.gBoxLed.Text = "Led";
            // 
            // lblLed4
            // 
            this.lblLed4.AutoSize = true;
            this.lblLed4.Location = new System.Drawing.Point(23, 111);
            this.lblLed4.Name = "lblLed4";
            this.lblLed4.Size = new System.Drawing.Size(34, 13);
            this.lblLed4.TabIndex = 7;
            this.lblLed4.Text = "Led 4";
            // 
            // lblLed3
            // 
            this.lblLed3.AutoSize = true;
            this.lblLed3.Location = new System.Drawing.Point(23, 82);
            this.lblLed3.Name = "lblLed3";
            this.lblLed3.Size = new System.Drawing.Size(34, 13);
            this.lblLed3.TabIndex = 7;
            this.lblLed3.Text = "Led 3";
            // 
            // btnLed4OFF
            // 
            this.btnLed4OFF.Location = new System.Drawing.Point(165, 106);
            this.btnLed4OFF.Name = "btnLed4OFF";
            this.btnLed4OFF.Size = new System.Drawing.Size(75, 23);
            this.btnLed4OFF.TabIndex = 6;
            this.btnLed4OFF.Text = "OFF";
            this.btnLed4OFF.UseVisualStyleBackColor = true;
            this.btnLed4OFF.Click += new System.EventHandler(this.btnLed4OFF_Click);
            // 
            // lblLed2
            // 
            this.lblLed2.AutoSize = true;
            this.lblLed2.Location = new System.Drawing.Point(23, 53);
            this.lblLed2.Name = "lblLed2";
            this.lblLed2.Size = new System.Drawing.Size(34, 13);
            this.lblLed2.TabIndex = 7;
            this.lblLed2.Text = "Led 2";
            // 
            // btnLed4ON
            // 
            this.btnLed4ON.Location = new System.Drawing.Point(84, 106);
            this.btnLed4ON.Name = "btnLed4ON";
            this.btnLed4ON.Size = new System.Drawing.Size(75, 23);
            this.btnLed4ON.TabIndex = 5;
            this.btnLed4ON.Text = "ON";
            this.btnLed4ON.UseVisualStyleBackColor = true;
            this.btnLed4ON.Click += new System.EventHandler(this.btnLed4ON_Click);
            // 
            // btnLed3OFF
            // 
            this.btnLed3OFF.Location = new System.Drawing.Point(165, 77);
            this.btnLed3OFF.Name = "btnLed3OFF";
            this.btnLed3OFF.Size = new System.Drawing.Size(75, 23);
            this.btnLed3OFF.TabIndex = 6;
            this.btnLed3OFF.Text = "OFF";
            this.btnLed3OFF.UseVisualStyleBackColor = true;
            this.btnLed3OFF.Click += new System.EventHandler(this.btnLed3OFF_Click);
            // 
            // btnLed2OFF
            // 
            this.btnLed2OFF.Location = new System.Drawing.Point(165, 48);
            this.btnLed2OFF.Name = "btnLed2OFF";
            this.btnLed2OFF.Size = new System.Drawing.Size(75, 23);
            this.btnLed2OFF.TabIndex = 6;
            this.btnLed2OFF.Text = "OFF";
            this.btnLed2OFF.UseVisualStyleBackColor = true;
            this.btnLed2OFF.Click += new System.EventHandler(this.btnLed2OFF_Click);
            // 
            // btnLed3ON
            // 
            this.btnLed3ON.Location = new System.Drawing.Point(84, 77);
            this.btnLed3ON.Name = "btnLed3ON";
            this.btnLed3ON.Size = new System.Drawing.Size(75, 23);
            this.btnLed3ON.TabIndex = 5;
            this.btnLed3ON.Text = "ON";
            this.btnLed3ON.UseVisualStyleBackColor = true;
            this.btnLed3ON.Click += new System.EventHandler(this.btnLed3ON_Click);
            // 
            // btnLed2ON
            // 
            this.btnLed2ON.Location = new System.Drawing.Point(84, 48);
            this.btnLed2ON.Name = "btnLed2ON";
            this.btnLed2ON.Size = new System.Drawing.Size(75, 23);
            this.btnLed2ON.TabIndex = 5;
            this.btnLed2ON.Text = "ON";
            this.btnLed2ON.UseVisualStyleBackColor = true;
            this.btnLed2ON.Click += new System.EventHandler(this.btnLed2ON_Click);
            // 
            // lblLed1
            // 
            this.lblLed1.AutoSize = true;
            this.lblLed1.Location = new System.Drawing.Point(23, 24);
            this.lblLed1.Name = "lblLed1";
            this.lblLed1.Size = new System.Drawing.Size(34, 13);
            this.lblLed1.TabIndex = 4;
            this.lblLed1.Text = "Led 1";
            // 
            // btnLed1OFF
            // 
            this.btnLed1OFF.Location = new System.Drawing.Point(165, 19);
            this.btnLed1OFF.Name = "btnLed1OFF";
            this.btnLed1OFF.Size = new System.Drawing.Size(75, 23);
            this.btnLed1OFF.TabIndex = 2;
            this.btnLed1OFF.Text = "OFF";
            this.btnLed1OFF.UseVisualStyleBackColor = true;
            this.btnLed1OFF.Click += new System.EventHandler(this.btnLed1OFF_Click);
            // 
            // btnLed1ON
            // 
            this.btnLed1ON.Location = new System.Drawing.Point(84, 19);
            this.btnLed1ON.Name = "btnLed1ON";
            this.btnLed1ON.Size = new System.Drawing.Size(75, 23);
            this.btnLed1ON.TabIndex = 1;
            this.btnLed1ON.Text = "ON";
            this.btnLed1ON.UseVisualStyleBackColor = true;
            this.btnLed1ON.Click += new System.EventHandler(this.btnLed1ON_Click);
            // 
            // gBoxTemp
            // 
            this.gBoxTemp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gBoxTemp.Controls.Add(this.chart);
            this.gBoxTemp.Location = new System.Drawing.Point(12, 156);
            this.gBoxTemp.Name = "gBoxTemp";
            this.gBoxTemp.Size = new System.Drawing.Size(509, 329);
            this.gBoxTemp.TabIndex = 4;
            this.gBoxTemp.TabStop = false;
            this.gBoxTemp.Text = "Temperatura";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(6, 19);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(497, 300);
            this.chart.TabIndex = 0;
            this.chart.Text = "Temperatura";
            // 
            // rtxtOut
            // 
            this.rtxtOut.Location = new System.Drawing.Point(264, 12);
            this.rtxtOut.Name = "rtxtOut";
            this.rtxtOut.Size = new System.Drawing.Size(257, 75);
            this.rtxtOut.TabIndex = 5;
            this.rtxtOut.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.btnBaixo);
            this.groupBox1.Controls.Add(this.btnCima);
            this.groupBox1.Controls.Add(this.btnDir);
            this.groupBox1.Controls.Add(this.btnEsq);
            this.groupBox1.Location = new System.Drawing.Point(527, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controle WebCam";
            // 
            // btnBaixo
            // 
            this.btnBaixo.Location = new System.Drawing.Point(87, 53);
            this.btnBaixo.Name = "btnBaixo";
            this.btnBaixo.Size = new System.Drawing.Size(215, 35);
            this.btnBaixo.TabIndex = 4;
            this.btnBaixo.Text = "Baixo";
            this.btnBaixo.UseVisualStyleBackColor = true;
            this.btnBaixo.Click += new System.EventHandler(this.btnBaixo_Click);
            // 
            // btnCima
            // 
            this.btnCima.Location = new System.Drawing.Point(87, 15);
            this.btnCima.Name = "btnCima";
            this.btnCima.Size = new System.Drawing.Size(215, 32);
            this.btnCima.TabIndex = 3;
            this.btnCima.Text = "Cima";
            this.btnCima.UseVisualStyleBackColor = true;
            this.btnCima.Click += new System.EventHandler(this.btnCima_Click);
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(308, 15);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(75, 73);
            this.btnDir.TabIndex = 2;
            this.btnDir.Text = "Direita";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // btnEsq
            // 
            this.btnEsq.Location = new System.Drawing.Point(6, 15);
            this.btnEsq.Name = "btnEsq";
            this.btnEsq.Size = new System.Drawing.Size(75, 73);
            this.btnEsq.TabIndex = 1;
            this.btnEsq.Text = "Esquerda";
            this.btnEsq.UseVisualStyleBackColor = true;
            this.btnEsq.Click += new System.EventHandler(this.btnEsq_Click);
            // 
            // gBoxWebcam
            // 
            this.gBoxWebcam.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gBoxWebcam.Controls.Add(this.pBoxWeb);
            this.gBoxWebcam.Location = new System.Drawing.Point(527, 12);
            this.gBoxWebcam.Name = "gBoxWebcam";
            this.gBoxWebcam.Size = new System.Drawing.Size(389, 373);
            this.gBoxWebcam.TabIndex = 3;
            this.gBoxWebcam.TabStop = false;
            this.gBoxWebcam.Text = "Webcam";
            // 
            // pBoxWeb
            // 
            this.pBoxWeb.Location = new System.Drawing.Point(18, 17);
            this.pBoxWeb.Name = "pBoxWeb";
            this.pBoxWeb.Size = new System.Drawing.Size(350, 350);
            this.pBoxWeb.TabIndex = 0;
            this.pBoxWeb.TabStop = false;
            // 
            // Controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 497);
            this.Controls.Add(this.gBoxWebcam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtxtOut);
            this.Controls.Add(this.gBoxTemp);
            this.Controls.Add(this.gBoxLed);
            this.Controls.Add(this.gBoxL220);
            this.MaximizeBox = false;
            this.Name = "Controle";
            this.ShowIcon = false;
            this.Text = "Controle";
            this.gBoxL220.ResumeLayout(false);
            this.gBoxLed.ResumeLayout(false);
            this.gBoxLed.PerformLayout();
            this.gBoxTemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gBoxWebcam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxWeb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxL220;
        private System.Windows.Forms.Button btnOFF220;
        private System.Windows.Forms.Button btnON220;
        private System.Windows.Forms.GroupBox gBoxLed;
        private System.Windows.Forms.Label lblLed4;
        private System.Windows.Forms.Label lblLed3;
        private System.Windows.Forms.Button btnLed4OFF;
        private System.Windows.Forms.Label lblLed2;
        private System.Windows.Forms.Button btnLed4ON;
        private System.Windows.Forms.Button btnLed3OFF;
        private System.Windows.Forms.Button btnLed2OFF;
        private System.Windows.Forms.Button btnLed3ON;
        private System.Windows.Forms.Button btnLed2ON;
        private System.Windows.Forms.Label lblLed1;
        private System.Windows.Forms.Button btnLed1OFF;
        private System.Windows.Forms.Button btnLed1ON;
        private System.Windows.Forms.GroupBox gBoxTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.RichTextBox rtxtOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBaixo;
        private System.Windows.Forms.Button btnCima;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnEsq;
        private System.Windows.Forms.GroupBox gBoxWebcam;
        private System.Windows.Forms.PictureBox pBoxWeb;
    }
}

