using System;

namespace StandSorusu
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Stand sayisini giriniz");
            int x = int.Parse(Console.ReadLine());

            Hesaplamalar h = new Hesaplamalar(x);
            h.StandDoldur();
            h.EnFazlaZiyaretEdilenStandBul();
            h.EnYaslılarıBul();
            h.OrtalamalarıBul();
            h.AlanlarıBul();
        }
    }
}