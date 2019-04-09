using System;

namespace StandSorusu
{
    public class Personel
    {
        public int cinsiyet; //1-kadin 2-erkek
        public int yas;
        public string isim;

        public void BilgiAl()
        {
            Console.WriteLine("Personelin ismini giriniz");
            isim = Console.ReadLine();

            Console.WriteLine("Personelin cinsiyetini Giriniz(1-kadın,2-erkek)");
            cinsiyet = int.Parse(Console.ReadLine());

            Console.WriteLine("Personelin yasini giriniz");
            yas = int.Parse(Console.ReadLine());
        }
    }
}