using System;

namespace ExtraMoneyForKids
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("işyerinde çalışan eleman sayisini giriniz");
            int x = Convert.ToInt32(Console.ReadLine());

            Personel p = new Personel(x);
            p.BilgiAl();
            p.Yazdır();
        }
    }
}