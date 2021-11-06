using System;

namespace HomeWork4

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The number of elements in the array ==>");
            int n = Convert.ToInt32(Console.ReadLine()); // const number of elements in the array
            double[] array = new double[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-100, 100) + Math.Round(rand.NextDouble(), 2); //Fills an array with negative numbers from -100 to 100, with number of decimal places = 2
                Console.Write(Math.Round(array[i], 2) + ", ");
            }
            double max = -999999;
            double ssum = 0;
            int index_plus = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                    max = array[i]; // Maximum array element
            }


            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    index_plus = i;//index of the last positive element
                    break;
                }
            }

            for (int i = 0; i <= index_plus; i++)
            {

                ssum += array[i];
            }


            Console.WriteLine("\nMaximum array element=" + Math.Round(max, 2));
            if (index_plus == 0 && array[0] < 0)

                Console.WriteLine("Nет positive elements");
            else
                Console.WriteLine("Sum up to the last positive element=" + Math.Round(ssum, 2));




            double a = array[0];
            double b = array[array.Length - 1];
            double[] new_array = new double[array.Length];


            for (int i = 0, j = 0; i < array.Length - 1; i++)
            {

                if (Math.Abs(array[i]) > Math.Max(a, b) || Math.Abs(array[i]) < Math.Min(a, b))
                {
                    new_array[j++] = array[i];
                }
            }
            foreach (double s in new_array)
                Console.Write(s + ", "); //New array

            //---------------------------------------------------------------------//
            Console.WriteLine("\n//---------------------------------------------------------------------//");
            Console.WriteLine("\nNumber of elements in an array ==>");


            int y = Convert.ToInt32(Console.ReadLine());
            double[,] aa = new double[y, y];

            Random random = new Random();
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    aa[i, j] = random.Next(-100, 100) + random.NextDouble();
                    Console.Write(Math.Round(aa[i, j], 2) + " ");
                }
                Console.WriteLine();
            }
            double sum = 0;
            double sum_row = 0;
            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < y; i++)
                {
                    if (aa[i, j] > 0)
                        sum_row = sum_row + aa[i, j];
                    else
                        sum_row = 0;
                    break;
                }
                sum = sum_row + sum;
            }
            Console.WriteLine("Sum of columns where there are no negative ones= " + Math.Round(sum, 2));

            double s1 = 0; double s2 = 0;
            for (int i = 0; i < aa.GetLength(0); i++)
                if (i == 0) s1 += Math.Abs(aa[i, aa.GetLength(0) - i - 2]);
                else if (i == aa.GetLength(0) - 1) s2 += Math.Abs(aa[i, aa.GetLength(0) - i]);
                else
                {
                    s1 += Math.Abs(aa[i, aa.GetLength(0) - i - 2]);
                    s2 += Math.Abs(aa[i, aa.GetLength(0) - i]);
                }
            Console.WriteLine($"Amounts: {Math.Round(s1, 2)}, {Math.Round(s2, 2)}");

        }
    }
}
