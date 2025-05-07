using System;
using System.Collections.Generic;
using System.Linq;

namespace GenetikAlgoritmaCozumu
{
    // Genetik Algoritmanın ana class'ı (yönetici sınıf)
    public class GeneticAlgorithm
    {
        // Popülasyon nesnesi (bireyler grubunu içerir)
        public Population Population { get; set; }

        // Genetik algoritmanın temel ayarları
        public int PopulationSize { get; set; }      // Popülasyondaki birey sayısı
        public int GenerationCount { get; set; }     // Döngü sayısı (nesillerin sayısı)
        public double CrossoverRate { get; set; }    // Çaprazlama oranı
        public double MutationRate { get; set; }     // Mutasyon oranı
        public double ElitismRate { get; set; }      // Seçkinlik oranı (en iyi bireylerin korunması)
        public int GeneCount { get; set; }           // Her bireydeki gen sayısı (örneğin x,y için 2 gen)
        public double MinGeneValue { get; set; }     // Gen değerlerinin alabileceği minimum değer
        public double MaxGeneValue { get; set; }     // Gen değerlerinin alabileceği maksimum değer

        // Rastgele sayı üretici nesne (Random)
        public Random rnd { get; set; }

        // Jenerasyonlar boyunca bulunan en iyi fitness değerlerinin kayıt listesi (grafik için)
        public List<double> BestFitnessHistory { get; set; }

        // Constructor - Yeni bir genetik algoritma için gerekli parametreler ayarlanır
        public GeneticAlgorithm(int populationSize, int generationCount, double crossoverRate,
                                double mutationRate, double elitismRate, int geneCount,
                                double minGeneValue, double maxGeneValue)
        {
            PopulationSize = populationSize;
            GenerationCount = generationCount;
            CrossoverRate = crossoverRate;
            MutationRate = mutationRate;
            ElitismRate = elitismRate;
            GeneCount = geneCount;
            MinGeneValue = minGeneValue;
            MaxGeneValue = maxGeneValue;
            rnd = new Random();

            BestFitnessHistory = new List<double>();
        }

        // Başlangıç popülasyonunu oluşturur ve fitness değerlerini hesaplar
        public void Initialize()
        {
            Population = new Population(PopulationSize, GeneCount, MinGeneValue, MaxGeneValue, rnd);
            EvaluateFitness(Population); // İlk fitness hesaplanır
        }

        // Tüm bireylerin fitness değerlerini hesaplar ve atar
        public void EvaluateFitness(Population pop)
        {
            foreach (var ind in pop.Individuals)
            {
                ind.Fitness = Problem.Evaluate(ind.Genes); // Problem fonksiyonu burada çağrılır
            }
        }

        // Algoritmayı nesil döngüsü kadar çalıştırır ve en iyi sonucu döner
        public Individual Run()
        {
            Initialize();

            for (int generation = 0; generation < GenerationCount; generation++)
            {
                Population nextGen = CreateNextGeneration(); // Sonraki nesil oluşturulur
                EvaluateFitness(nextGen);                    // Yeni neslin Fitness değerleri hesaplanır
                Population = nextGen;                        // Nesil güncellenir

                // Nesildeki en iyi bireyi bul ve kaydet (grafik için)
                Individual best = Population.GetBestIndividual();
                BestFitnessHistory.Add(best.Fitness);
            }

            // Algoritmanın sonunda bulunan en iyi çözüm döner
            return Population.GetBestIndividual();
        }

        // Turnuva Seçimi metodu - rakipler arasından en iyi bireyi seçer
        public Individual TournamentSelection(int tournamentSize)
        {
            Individual best = null;
            for (int i = 0; i < tournamentSize; i++)
            {
                Individual temp = Population.Individuals[rnd.Next(PopulationSize)];
                if (best == null || temp.Fitness < best.Fitness)
                    best = temp;
            }
            return best.Clone(); // Kazanan bireyin bir kopyası döner
        }

        // Çaprazlama(Crossover) işlemi - iki ebeveyn bireyden yavru birey oluşturur
        public Individual Crossover(Individual parent1, Individual parent2)
        {
            Individual child = parent1.Clone();

            if (rnd.NextDouble() < CrossoverRate) // Çaprazlama gerçekleşme oranına göre gerçekleşir
            {
                for (int i = 0; i < GeneCount; i++)
                {
                    double alpha = rnd.NextDouble();
                    child.Genes[i] = alpha * parent1.Genes[i] + (1 - alpha) * parent2.Genes[i];
                }
            }
            return child;
        }

        // Mutasyon işlemi - bireyin genlerinde küçük değişiklikler yapar
        public void Mutate(Individual ind)
        {
            for (int i = 0; i < GeneCount; i++)
            {
                if (rnd.NextDouble() < MutationRate) // Mutasyon gerçekleşme oranına göre gerçekleşir
                {
                    ind.Genes[i] = rnd.NextDouble() * (MaxGeneValue - MinGeneValue) + MinGeneValue;
                }
            }
        }

        // Yeni nesli oluşturur (Elitizm, Seçim, Çaprazlama ve Mutasyon işlemleri içerir)
        public Population CreateNextGeneration()
        {
            // Boş yeni nesil oluşturulur
            Population nextGen = new Population(PopulationSize, GeneCount, MinGeneValue, MaxGeneValue, rnd);
            int elitismCount = (int)(ElitismRate * PopulationSize);

            // Mevcut nesilden fitness değerine göre sıralama yapılır
            var sortedList = Population.Individuals.OrderBy(ind => ind.Fitness).ToList();

            // En iyi bireyleri (elitleri) doğrudan bir sonraki nesle aktarır
            for (int i = 0; i < elitismCount; i++)
            {
                nextGen.Individuals[i] = sortedList[i].Clone();
            }

            // Geri kalan bireyleri çaprazlama ve mutasyon yaparak doldurur
            for (int i = elitismCount; i < PopulationSize; i++)
            {
                Individual parent1 = TournamentSelection(3); // 1. ebeveyn seçilir
                Individual parent2 = TournamentSelection(3); // 2. ebeveyn seçilir
                Individual child = Crossover(parent1, parent2);  // Yavru oluşturulur
                Mutate(child); // Yavruda mutasyon gerçekleştirilir
                nextGen.Individuals[i] = child; // Yeni birey nesle eklenir
            }

            return nextGen; // Yeni nesil döner
        }
    }
}