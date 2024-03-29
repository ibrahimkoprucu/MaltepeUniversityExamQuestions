﻿using System;

namespace StandSorusu
{
    public class Hesaplamalar
    {
        public int standSayisi;
        public Stand[] standlar;

        public Hesaplamalar(int x)
        {
            standSayisi = x;
            standlar = new Stand[x];
        }

        public void StandDoldur()
        {
            for (int i = 0; i < standSayisi; i++)
            {
                Console.WriteLine("--------------{0}.Standın Bilgileri:-----------", i + 1);
                Console.WriteLine("Standta çalışacak personel sayisini giriniz");
                int k = int.Parse(Console.ReadLine());
                Stand s = new Stand(k);
                s.standNo = i + 1;
                s.BilgiAl();
                standlar[i] = s;
            }
        }

        public void EnFazlaZiyaretEdilenStandBul()
        {
            int max1 = 0;
            Stand s1 = null;
            int max2 = 0;
            Stand s2 = null;
            foreach (var stand in standlar)
            {
                if (stand.ziyaretciSayisi > max1)
                {
                    max2 = max1;
                    s2 = s1;
                    max1 = stand.ziyaretciSayisi;
                    s1 = stand;
                }
                else if (stand.ziyaretciSayisi > max2)
                {
                    max2 = stand.ziyaretciSayisi;
                    s2 = stand;
                }
            }

            Console.WriteLine("enfazla ziyaret edilen standın Bilgileri: ");
            Console.WriteLine(s1);

            Console.WriteLine("enfazla ziyaret edilen 2.standın Bilgileri: ");
            Console.WriteLine(s2);
        }

        public void EnYaslılarıBul()
        {
            try
            {
                Stand sKadın = null;
                Stand sErkek = null;
                int maxKadınYas = 0;
                int maxErkekYas = 0;

                foreach (var stand in standlar)
                {
                    if (stand.EnyasliKadin.yas > maxKadınYas)
                    {
                        maxKadınYas = stand.EnyasliKadin.yas;
                        sKadın = stand;
                    }

                    if (stand.EnyasliErkek.yas > maxErkekYas)
                    {
                        maxErkekYas = stand.EnyasliErkek.yas;
                        sErkek = stand;
                    }
                }

                Console.WriteLine("En yaşlı kadının bulunduğu stand: {0} nolu standtır", sKadın.standNo);

                Console.WriteLine("Enyaşlı erkeğin bulunduğu stand: {0} nolu standtır", sErkek.standNo);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void OrtalamalarıBul()
        {
            int toplamKadinSayisi = 0;
            int toplamErkekSayisi = 0;

            foreach (var stand in standlar)
            {
                toplamErkekSayisi += stand.ErkekSayisi;
                toplamKadinSayisi += stand.KadinSayisi;
            }

            Console.WriteLine("Kadın ortalama={0}", toplamKadinSayisi / standSayisi);
            Console.WriteLine("Erkek ortalama={0}", toplamErkekSayisi / standSayisi);
        }

        public void AlanlarıBul()
        {
            int onluk = 0;
            int onbeslik = 0;

            foreach (var stand in standlar)
            {
                if (stand.alan == 10)
                {
                    onluk++;
                }

                if (stand.alan == 15)
                {
                    onbeslik++;
                }
            }

            Console.WriteLine("10 m2 lik alana sahip stand sayisi={0}", onluk);
            Console.WriteLine("15 m2 lik alana sahip stand sayisi={0}", onbeslik);
        }
    }
}