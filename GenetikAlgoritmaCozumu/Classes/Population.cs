using System;
using System.Linq;

namespace GenetikAlgoritmaCozumu
{
    // Popülasyonu (birey topuluğunu) temsil eden sınıf
    public class Population
    {
        // Bireyleri barındıran liste
        public Individual[] Individuals { get; set; }

        // Yeni popülasyon oluşturucu (başlangıç için)
        public Population(int populationSize, int geneCount, double minValue, double maxValue, Random rnd)
        {
            // Popülasyon dizisini oluşturup bireylere rastgele değerleri ata
            Individuals = new Individual[populationSize];

            for (int i = 0; i < populationSize; i++)
            {
                Individuals[i] = new Individual(geneCount);
                Individuals[i].Initialize(minValue, maxValue, rnd);
            }
        }

        // Popülasyondaki en iyi çözümü bulan ve döndüren metot
        public Individual GetBestIndividual()
        {
            // Fitness değerine göre sıralayıp ilk bireyi (en iyi) klonlayarak döndürür
            return Individuals.OrderBy(ind => ind.Fitness).First().Clone();
        }
    }
}