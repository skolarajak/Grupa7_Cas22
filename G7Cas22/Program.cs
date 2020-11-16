using System;
using System.Collections.Generic;


namespace G7Cas22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jednodimenzionalni nizovi:\n");
            arrays();
            Console.WriteLine("Višedimenzionalni nizovi:\n");
            multidimensionalArrays();
            Console.WriteLine("Ugnježdeni (nested) nizovi:\n");
            nestedArrays();
            Console.WriteLine("Parametarski nizovi:\n");
            ParamArrays();
            Console.WriteLine("Liste:\n");
            Lists();

            Console.ReadKey();
        }

        static void Lists()
        {
            List<int> brojevi = new List<int>();
            List<string> reci = new List<string>();

            string unos;
            do
            {
                Console.Write("Unesite broj (ostaviti prazno za kraj rada) >");
                unos = Console.ReadLine();

                if (unos != "")
                {
                    brojevi.Add(Convert.ToInt32(unos));
                }

            } while (unos != "");

            do
            {
                Console.Write("Unesite reč (ostaviti prazno za kraj rada) >");
                unos = Console.ReadLine();
                if (unos != "")
                {
                    reci.Add(unos);
                }

            } while (unos != "");

            int rezultat = SumElementsList(brojevi);
            Console.WriteLine("Suma unetih brojeva je: {0}", rezultat);

            Console.WriteLine("Unete reči su: ");
            foreach(string rec in reci)
            {
                Console.Write("{0} ", rec);
            }
            Console.WriteLine("");
        }

        static int SumElementsList(List<int> numbers)
        {
            int sum = 0;

            foreach(int number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        static void ParamArrays()
        {
            int sum = SumElements(1, 5);

            Console.WriteLine("The sum is: {0}", sum);
        }


        static int SumElements(params int[] arr)
        {
            int sum = 0;

            foreach(int n in arr)
            {
                sum += n;
            }

            return sum;
        }

        static void ArraysAsParams()
        {
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg;

            avg = GetAverage(balance);

            Console.WriteLine("Prosecna vrednost je: {0}", avg);
        }

        static double GetAverage(int[] arr)
        {
            double avg;
            int sum = 0;
            int size = arr.Length;

            for(int i = 0; i < size; i++)
            {
                sum += arr[i]; // skraceno od sum = sum + arr[i];
            }

            avg = sum / size;
            return avg;
        }

        static void nestedArrays()
        {
            int[][] a = new int[][] { new int[] { 0, 0 }, new int[] { 1, 2 },
                new int[] { 2, 4 }, new int[] { 3, 6 }, new int[] { 4, 8 } };

            int[][] b = new int[5][];

            b[0] = new int[10];
            b[1] = new int[5];
            b[2] = new int[100];
            b[3] = new int[2];
            b[4] = new int[99];


            int i, j;

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("Clan n[{0}][{1}] = {2}", i, j, a[i][j]);
                }
            }
        }

        static void multidimensionalArrays()
        {
            int[,] n = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int i, j;

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("Clan n[{0}, {1}] = {2}", i, j, n[i, j]);
                }
            }
        }

        static void arrays()
        {
            int[] n = new int[10]; // Predstavlja niz od 10 elemenata integer tipa (0 do 9)
            int i, j;

            // Inicijalizacija niza n
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            // Ispis vrednosti elemenata niza
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("[for] Clan n[{0}] = {1}", j, n[j]);
            }

            int sum = 0;
            foreach (int k in n)
            {
                sum = sum + k;
            }
            Console.WriteLine("Zbir vrednosti elemenata niza = {0}", sum);
        }
    }
}
