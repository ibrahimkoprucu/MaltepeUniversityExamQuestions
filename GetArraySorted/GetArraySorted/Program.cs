using System;

namespace GetArraySorted
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] dizi = new int[5];
            int temp;
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("Bir sayi giriniz");
                dizi[i] = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < dizi.Length; j++)
                {
                    if (dizi[j] > dizi[i])
                    {
                        temp = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = temp;
                    }
                }
            }
        }

        public static void DiziYaz(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0} ", A[i]);
            }

            Console.WriteLine();
        }
    }
}