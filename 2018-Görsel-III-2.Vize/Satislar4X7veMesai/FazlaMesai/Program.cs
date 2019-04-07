using System;

namespace FazlaMesai
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("eleman sayisini giriniz");

            int k = int.Parse(Console.ReadLine());

            Isyeri i = new Isyeri(k);

            i.BilgiAl();
            i.Yazdır();
        }
    }
}