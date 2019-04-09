using System;

namespace StandSorusu
{
    public enum Konu
    {
        yazılım,
        donanım,
        yapayzeka
    }

    public class Stand
    {
        public double alan;//m2
        public Personel[] personeller;
        public int calisanSayisi;
        public int ziyaretciSayisi;
        public Konu konu;
        public int standNo;

        public Stand(int k)
        {
            calisanSayisi = k;
            personeller = new Personel[k];
        }

        public int KadinSayisi
        {
            get
            {
                int sayac = 0;

                foreach (var p in personeller)
                {
                    if (p.cinsiyet == 1)
                    {
                        sayac++;
                    }
                }

                return sayac;
            }
        }

        public int ErkekSayisi
        {
            get { return calisanSayisi - KadinSayisi; }
        }

        public Personel EnyasliErkek
        {
            get
            {
                Personel enYasli = null;
                int maxYas = 0;

                foreach (var p in personeller)
                {
                    if (p.cinsiyet == 1)
                    {
                        if (p.yas > maxYas)
                        {
                            maxYas = p.yas;
                            enYasli = p;
                        }
                    }
                }

                return enYasli;
            }
        }

        public Personel EnyasliKadin
        {
            get
            {
                Personel enYasli = null;
                int maxYas = 0;

                foreach (var p in personeller)
                {
                    if (p.cinsiyet == 2)
                    {
                        if (p.yas > maxYas)
                        {
                            maxYas = p.yas;
                            enYasli = p;
                        }
                    }
                }

                return enYasli;
            }
        }

        public override string ToString()
        {
            string str = string.Format("Alan={0} Calisan Sayisi={1} Kadin Sayisi={2} Erkek Sayisi={3}\n Ziyaretci Sayisi={4} Konu={5}", alan, calisanSayisi, KadinSayisi, ErkekSayisi, ziyaretciSayisi, konu);

            return str;
        }

        public void BilgiAl()
        {
            //Console.WriteLine("----------{0}.Standın Bilgileri----------", standNo);
            Console.WriteLine("Standın alan bilgisini giriniz");
            alan = double.Parse(Console.ReadLine());

            Console.WriteLine("Standın konusunu giriniz:(1-2-3)");

            konu = (Konu)int.Parse(Console.ReadLine());

            Console.WriteLine("Standın Ziyaretci Sayisini giriniz");
            ziyaretciSayisi = int.Parse(Console.ReadLine());

            PersonelDoldur();
        }

        private void PersonelDoldur()
        {
            for (int i = 0; i < calisanSayisi; i++)
            {
                Console.WriteLine("Bu standtaki {0}. calisanın bilgileri ", i + 1);
                Personel p = new Personel();
                p.BilgiAl();
                personeller[i] = p;
            }
        }
    }
}