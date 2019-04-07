using System;

namespace ExtraMoneyForKids
{
    public class Personel
    {
        private const int kategori = 3;
        private int[,] personelBilgileri;
        private int elemanSayisi;
        private string[] isimler;

        public Personel(int i)
        {
            personelBilgileri = new int[i, kategori];
            isimler = new string[i];
            elemanSayisi = i;
        }

        public void BilgiAl()
        {
            for (int i = 0; i < elemanSayisi; i++)
            {
                Console.WriteLine("{0}. eleman", i + 1);
                Console.WriteLine("ismini giriniz");
                isimler[i] = Console.ReadLine();
                Console.WriteLine("çocuk sayisini giriniz");
                int k = Convert.ToInt32(Console.ReadLine());
                personelBilgileri[i, 0] = k;
                Console.WriteLine("Maaşını giriniz");
                int maas = int.Parse(Console.ReadLine());
                personelBilgileri[i, 1] = maas;
            }
            ToplamUcretBul();
        }

        private int ExtraPara(int k)
        {
            switch (k)
            {
                case 1:
                    return 100;

                case 2:
                    return 250;

                case 0:
                    return 0;

                default:
                    return 400;
            }
        }

        private void ToplamUcretBul()
        {
            for (int i = 0; i < elemanSayisi; i++)
            {
                personelBilgileri[i, 2] = ExtraPara(personelBilgileri[i, 0]) + personelBilgileri[i, 1];
            }
        }

        public void Yazdır()
        {
            for (int i = 0; i < elemanSayisi; i++)
            {
                Console.WriteLine("{0} isimli elemanın ay sonunda toplam alacağı ücret={1}", isimler[i], personelBilgileri[i, 2]);
            }
        }
    }
}