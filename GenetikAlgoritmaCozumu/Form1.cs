using System;
using System.Windows.Forms;

namespace GenetikAlgoritmaCozumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //  Varsayılan Parametrelerin Ayarlandığı Yer:
            txtPopulasyonBoyutu.Text = "100";
            txtJenerasyonSayisi.Text = "50"; 
            txtCaprazlamaOrani.Text = "0,8"; 
            txtMutasyonOrani.Text = "0,08"; 
            txtSeckinlik.Text = "0,1"; 

            //  Grafik Ayarlarının Yapıldığı Yer: (Grafik ismi ve eksenleri)
            if (chartYakinama.Series.Count > 0)
            {
                chartYakinama.Series[0].Name = "En İyi Fitness";
                chartYakinama.ChartAreas[0].AxisX.Title = "Jenerasyon";
                chartYakinama.ChartAreas[0].AxisY.Title = "Fitness Değeri";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
        
                lblSonuc.Text = "Hesaplanıyor...";
                Application.DoEvents();

                //  Kullanıcının Girdiği Parametrelerin Alındığı Yer:
                int populationSize = int.Parse(txtPopulasyonBoyutu.Text);
                int generationCount = int.Parse(txtJenerasyonSayisi.Text);
                double crossoverRate = double.Parse(txtCaprazlamaOrani.Text);
                double mutationRate = double.Parse(txtMutasyonOrani.Text);
                double elitismRate = double.Parse(txtSeckinlik.Text);

                //  Optimizasyon Probleminin Özellikleri Buradan Ayarlanıyor:
                int geneCount = 2;                // Problemin değişken sayısı (x ve y için)
                double minGeneValue = -4.5;      // Genlerin (x,y) alabileceği minimum değer
                double maxGeneValue = 4.5;       // Genlerin (x,y) alabileceği maksimum değer

                //  Genetik Algoritmanın Başlatıldığı Kısım:
                GeneticAlgorithm ga = new GeneticAlgorithm(
                    populationSize, generationCount, crossoverRate,
                    mutationRate, elitismRate, geneCount, minGeneValue, maxGeneValue
                );

                //  Algoritmanın Çalıştırılıp En iyi Çözümün bulunması
                Individual best = ga.Run();

                //  Bulunan Sonucu Form Üzerinde Gösterme
                lblSonuc.Text = $"En iyi bulunan çözüm:\r\n\r\n" +
                                $"x = {best.Genes[0]:0.0000}\r\n" +
                                $"y = {best.Genes[1]:0.0000}\r\n\r\n" +
                                $"Amaç Fonksiyon Değeri = {best.Fitness:0.0000}";

                //  Grafik Verilerini Temizleme
                chartYakinama.Series[0].Points.Clear();

                //  Grafik Y ekseni Değer Aralığını Sabitleme (Her zaman aynı aralık ortaya çıkar)
                chartYakinama.ChartAreas[0].AxisY.Minimum = 0;     // Y ekseni minimum değeri
                chartYakinama.ChartAreas[0].AxisY.Maximum = 0.20;  // Y ekseni maksimum değeri 
                chartYakinama.ChartAreas[0].AxisY.Interval = 0.02; // Y ekseni bölme aralıkları 
                chartYakinama.ChartAreas[0].AxisY.LabelStyle.Format = "0.00"; // Y eksenindeki sayı formatı
                chartYakinama.ChartAreas[0].RecalculateAxesScale();

                //  Yakınsama Grafiğinin Gerçek Veriler ile Çizimi
                for (int i = 0; i < ga.BestFitnessHistory.Count; i++)
                {
                    chartYakinama.Series[0].Points.AddXY(i + 1, ga.BestFitnessHistory[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void chartYakinama_Click(object sender, EventArgs e) { }
        private void btnBaslat_Load(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void lblSonuc_Click(object sender, EventArgs e) { }
    }
}