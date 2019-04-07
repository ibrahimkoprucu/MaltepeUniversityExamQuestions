using System;

namespace FazlaMesai
{
    internal class Isyeri
    {
        private const int gunSayisi = 3;
        public int elemanSayisi { get; set; }
        public Eleman[] elemanlar { get; set; }
        public int Kırklık { get; set; }
        public int Ellilik { get; set; }

        public Isyeri(int k)
        {
            elemanSayisi = k;
            elemanlar = new Eleman[k];
        }

        public void BilgiAl()
        {
            for (int i = 0; i < elemanSayisi; i++)
            {
                Console.WriteLine("\n-------{0}. elemanın bigileri------", i + 1);
                Eleman e = new Eleman();
                Console.WriteLine("Elemanın ismi:");
                e.isim = Console.ReadLine();
                Console.WriteLine("Elemanın maası:");
                e.maas = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Elemanın fazla mesai süresi:");

                for (int j = 0; j < gunSayisi; j++)
                {
                    Console.Write("{0}.gün: ", j + 1);
                    int temp = int.Parse(Console.ReadLine());
                    e.fazlaMesaiUcreti += FazlaMesaiUcretiHesapla(temp);
                    e.fazlaMesaiSüresi += temp;
                }
                elemanlar[i] = e;
            }

            Console.WriteLine();
        }

        private int FazlaMesaiUcretiHesapla(int k)
        {
            switch (k)
            {
                case 1:
                case 0:
                    return 0;

                case 2:
                    Ellilik += k;
                    return 50;

                default:
                    Kırklık += k;
                    return 40;
            }
        }

        public void Yazdır()
        {
            int maxFazlaMesai = 0;
            string maxFazlaMesaiIsim = string.Empty;

            for (int i = 0; i < elemanSayisi; i++)
            {
                if (elemanlar[i].fazlaMesaiUcreti > maxFazlaMesai)
                {
                    maxFazlaMesai = elemanlar[i].fazlaMesaiUcreti;
                    maxFazlaMesaiIsim = elemanlar[i].isim;
                }

                decimal ucret = elemanlar[i].fazlaMesaiUcreti + elemanlar[i].maas;

                Console.WriteLine("{0} nolu elemanın alcağı aylık ücret:{1}", i + 1, ucret);
            }

            Console.WriteLine();
            Console.WriteLine("Fazla mesai yapmayan elemanların isimleri:");
            bool yoktur = true;
            for (int i = 0; i < elemanSayisi; i++)
            {
                if (elemanlar[i].fazlaMesaiSüresi == 0)
                {
                    Console.Write("{0} ", elemanlar[i].isim);
                    yoktur = false;
                }
            }

            if (yoktur)
            {
                Console.WriteLine("Fazla mesai yapmayan eleman yoktur");
            }

            Console.WriteLine();
            Console.WriteLine("Ay sonunda toplamda  50 tl. den:{0},\n 40tl. den:{1} saat fazla mesai yapılmış", Ellilik, Kırklık);
            Console.WriteLine();
            Console.WriteLine("En fazla fazla mesai ücreti alan elemanın ismi:{0}\n aldığı toplam fazla mesai ücreti:{1}", maxFazlaMesaiIsim, maxFazlaMesai);
        }
    }
}