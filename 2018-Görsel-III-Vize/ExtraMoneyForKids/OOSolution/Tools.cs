using System;
using System.Collections.Generic;

namespace OOSolution
{
    public class Tools
    {
        private int _k;
        public List<Personel> List;
        public static int ElemanSayisi = 0;

        public Tools(int k)
        {
            _k = k;
            List = new List<Personel>(k);
        }

        public void BilgiAl()
        {
            while (_k > ElemanSayisi)
            {
                Console.WriteLine("Personnel ismini giriniz");
                var isim = Console.ReadLine();

                Console.WriteLine("Personnel Cocuk sayisini giriniz");
                var x = int.Parse(Console.ReadLine());

                Console.WriteLine("Personelin Maasını giriniz");
                var maas = decimal.Parse(Console.ReadLine());

                var p1 = new Personel(isim, x, maas);
                List.Add(p1);
            }
        }

        public Personel FindSmallestSalary()
        {
            decimal minSalary = decimal.MaxValue;
            Personel p = null;
            for (int i = 0; i < List.Count; i++)
            {
                if (HasOneChild(List[i]))
                {
                    if (List[i].UcretHesapla() < minSalary)
                    {
                        minSalary = List[i].UcretHesapla();
                        p = List[i];
                    }
                }
            }

            return p;
        }

        private bool HasOneChild(Personel p)
        {
            bool hasOneChild = false;

            if (p._cocuksayisi == 1)
            {
                hasOneChild = true;
            }

            return hasOneChild;
        }
    }
}