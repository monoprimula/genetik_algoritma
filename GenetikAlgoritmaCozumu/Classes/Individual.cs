using System;

namespace GenetikAlgoritmaCozumu
{
    // Bireyi (çözüm adayı) temsil eden sınıf
    public class Individual
    {
        // Genleri tutar (x,y gibi problemin değişkenleri)
        public double[] Genes { get; set; }

        // Uygunluk (fitness) değeri. İyi çözüm → düşük fitness.
        public double Fitness { get; set; }

        // Birey oluşturur 
        public Individual(int geneCount)
        {
            Genes = new double[geneCount];
            Fitness = double.MaxValue; // minimizasyon problemi olduğundan
        }

        // Başlangıçta rastgele gen değeri ataması
        public void Initialize(double minValue, double maxValue, Random rnd)
        {
            for (int i = 0; i < Genes.Length; i++)
            {
                Genes[i] = rnd.NextDouble() * (maxValue - minValue) + minValue;
            }
        }

        // Bireyi doğrudan kopyalar
        public Individual Clone()
        {
            Individual clone = new Individual(Genes.Length);

            for (int i = 0; i < Genes.Length; i++)
            {
                clone.Genes[i] = Genes[i];
            }

            clone.Fitness = Fitness;

            return clone;
        }
    }
}