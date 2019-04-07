using System;

namespace Satislar4X7
{
    public class Satis
    {
        private const int haftaSayisi = 2;//test amaçlı küçük değerler verilmiştir
        private const int gunSayisi = 2;

        private int[,] satislar = new int[haftaSayisi, gunSayisi];

        public void BilgiAl()
        {
            for (int i = 0; i < haftaSayisi; i++)
            {
                for (int j = 0; j < gunSayisi; j++)
                {
                    Console.WriteLine("{0}.hafta {1}.gün satış tutarını giriniz", i + 1, j + 1);
                    satislar[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Hesapla()
        {
            int maxSatis = 0;
            int maxSatis2 = 0;
            int maxHaftaNo = 0;
            int maxHaftaNo2 = 0;

            for (int i = 0; i < haftaSayisi; i++)
            {
                int toplamSatis = 0;

                for (int j = 0; j < gunSayisi; j++)
                {
                    toplamSatis += satislar[i, j];

                    if (toplamSatis >= maxSatis)
                    {
                        maxSatis2 = maxSatis;
                        maxHaftaNo2 = maxHaftaNo;
                        maxSatis = toplamSatis;
                        maxHaftaNo = i + 1;
                    }
                    else if (maxSatis2 > toplamSatis)
                    {
                        maxSatis2 = toplamSatis;
                        maxHaftaNo2 = i + 1;
                    }
                }
            }

            Console.WriteLine(@"
            en yüksek satis:{0}
            en yüksek satisin olduğu hafta:{1}
            en yüksek ikinci satis:{2}
            en yüksek ikinci satisin olduğu hafta:{3}", maxSatis, maxHaftaNo, maxSatis2, maxHaftaNo2);
        }
    }
}