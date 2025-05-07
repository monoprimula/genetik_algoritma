using System.Drawing;

namespace GenetikAlgoritmaCozumu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtJenerasyonSayisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSeckinlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMutasyonOrani = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaprazlamaOrani = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPopulasyonBoyutu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.chartYakinama = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartYakinama)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtJenerasyonSayisi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSeckinlik);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMutasyonOrani);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCaprazlamaOrani);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPopulasyonBoyutu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox1.Location = new System.Drawing.Point(31, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(577, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametreleri Giriniz";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(378, 282);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Algoritmayı Başlat ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtJenerasyonSayisi
            // 
            this.txtJenerasyonSayisi.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtJenerasyonSayisi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtJenerasyonSayisi.Location = new System.Drawing.Point(248, 236);
            this.txtJenerasyonSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.txtJenerasyonSayisi.Name = "txtJenerasyonSayisi";
            this.txtJenerasyonSayisi.Size = new System.Drawing.Size(128, 30);
            this.txtJenerasyonSayisi.TabIndex = 6;
            this.txtJenerasyonSayisi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jenerasyon Sayısı:";
            // 
            // txtSeckinlik
            // 
            this.txtSeckinlik.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtSeckinlik.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeckinlik.Location = new System.Drawing.Point(248, 184);
            this.txtSeckinlik.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeckinlik.Name = "txtSeckinlik";
            this.txtSeckinlik.Size = new System.Drawing.Size(128, 30);
            this.txtSeckinlik.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seçkinlik (oran/adet):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMutasyonOrani
            // 
            this.txtMutasyonOrani.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtMutasyonOrani.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMutasyonOrani.Location = new System.Drawing.Point(248, 142);
            this.txtMutasyonOrani.Margin = new System.Windows.Forms.Padding(4);
            this.txtMutasyonOrani.Name = "txtMutasyonOrani";
            this.txtMutasyonOrani.Size = new System.Drawing.Size(128, 30);
            this.txtMutasyonOrani.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mutasyon Oranı (0-1):";
            // 
            // txtCaprazlamaOrani
            // 
            this.txtCaprazlamaOrani.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtCaprazlamaOrani.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCaprazlamaOrani.Location = new System.Drawing.Point(248, 91);
            this.txtCaprazlamaOrani.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaprazlamaOrani.Name = "txtCaprazlamaOrani";
            this.txtCaprazlamaOrani.Size = new System.Drawing.Size(128, 30);
            this.txtCaprazlamaOrani.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Çaprazlama Oranı (0-1):";
            // 
            // txtPopulasyonBoyutu
            // 
            this.txtPopulasyonBoyutu.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtPopulasyonBoyutu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPopulasyonBoyutu.Location = new System.Drawing.Point(248, 48);
            this.txtPopulasyonBoyutu.Margin = new System.Windows.Forms.Padding(4);
            this.txtPopulasyonBoyutu.Name = "txtPopulasyonBoyutu";
            this.txtPopulasyonBoyutu.Size = new System.Drawing.Size(128, 30);
            this.txtPopulasyonBoyutu.TabIndex = 2;
            this.txtPopulasyonBoyutu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popülasyon Boyutu:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lblSonuc);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox2.Location = new System.Drawing.Point(31, 409);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(454, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "En İyi Çözüm Sonuçları";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblSonuc
            // 
            this.lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonuc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.Black;
            this.lblSonuc.Location = new System.Drawing.Point(22, 50);
            this.lblSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(401, 188);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Click += new System.EventHandler(this.lblSonuc_Click);
            // 
            // chartYakinama
            // 
            this.chartYakinama.BorderlineColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chartYakinama.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartYakinama.Legends.Add(legend1);
            this.chartYakinama.Location = new System.Drawing.Point(651, 274);
            this.chartYakinama.Name = "chartYakinama";
            this.chartYakinama.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerSize = 7;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            this.chartYakinama.Series.Add(series1);
            this.chartYakinama.Size = new System.Drawing.Size(398, 330);
            this.chartYakinama.TabIndex = 2;
            this.chartYakinama.Text = "Yakınsama Grafiği (Jenerasyon vs En iyi uygunluk değeri)";
            this.chartYakinama.Click += new System.EventHandler(this.chartYakinama_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Yakınsama Grafiği:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1087, 671);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chartYakinama);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Genetik Algoritma";
            this.Load += new System.EventHandler(this.btnBaslat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartYakinama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPopulasyonBoyutu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJenerasyonSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSeckinlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMutasyonOrani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaprazlamaOrani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYakinama;
        private System.Windows.Forms.Label label6;
    }
}

