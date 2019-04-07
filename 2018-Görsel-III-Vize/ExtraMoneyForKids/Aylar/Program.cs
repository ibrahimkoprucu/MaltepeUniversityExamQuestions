using System;

namespace Aylar
{
    public class Program
    {
        private const int gunSayisi = 2; //Test amaçlı 2 ye çekilmiştir normalde 30.
        private const int aySayisi = 3;

        private static void Main(string[] args)
        {
            int[,] mevsim = new int[aySayisi, gunSayisi];
            string[] aylar = { "Ocak", "Şubat", "Mart" };

            for (int i = 0; i < aySayisi; i++)
            {
                for (int j = 0; j < gunSayisi; j++)
                {
                    Console.WriteLine("{0} ayinin {1} gününün satış tutarını giriniz", aylar[i], j + 1);
                    mevsim[i, j] = int.Parse(Console.ReadLine());
                }
            }

            GetMaxMonth(mevsim, aylar);
        }

        public static void GetMaxMonth(int[,] mevsim, string[] A)
        {
            int max = 0;
            int toplamSatis;
            string ay = string.Empty;

            for (int i = 0; i < aySayisi; i++)
            {
                toplamSatis = 0;

                for (int j = 0; j < gunSayisi; j++)
                {
                    toplamSatis += mevsim[i, j];

                    if (toplamSatis > max)
                    {
                        max = toplamSatis;
                        ay = A[i];
                    }
                }
            }
            Console.WriteLine("En yüksek Satisin olduğu ay: {0} satıs tutarı: {1}", ay, max);
        }
    }
}