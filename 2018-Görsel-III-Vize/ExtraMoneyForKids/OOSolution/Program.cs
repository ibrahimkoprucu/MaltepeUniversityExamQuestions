using System;

namespace OOSolution
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("İşyerine alınacak eleman sınırını giriniz");
            int k = int.Parse(Console.ReadLine());

            var tools = new Tools(k);

            tools.BilgiAl();

            foreach (var personel in tools.List)
            {
                Console.WriteLine(value: personel);
            }
            Console.WriteLine("---------Sorunun b sıkkı-------en az ücret alan bir 1 çocuklu işçinin Bilgileri:");
            Personel p2 = tools.FindSmallestSalary();
            Console.WriteLine(p2);

            //for (int i = 0; i < 100; i++)
            //{
            //    string str = (i % 3 == 0 ? "fizz" : "") + (i % 5 == 0 ? "buzz" : "");

            //    Console.WriteLine(str == string.Empty ? i.ToString() : str);
            //}
        }
    }
}