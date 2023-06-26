using System;

namespace MainMatris
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array = new int[50, 50];
            Random rnd = new Random();

            Console.WriteLine();
            for (int i = 0; i <= 49; i++)
            {
                Console.Write("  {");
                for (int j = 0; j <= 49; j++)
                {
                    array[i, j] = rnd.Next(9);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("},");
            }
            Console.WriteLine("\n***********************************");

            MedianFilter(array);

        }
        private static void MedianFilter(int[,] arry)
        {


            int[,] filteredArry = new int[50, 50];

            for (int i = 0; i < 49; i++)
            {
                for (int j = 0; j < 49; j++)
                {
                    int sum = 0;
                    int count = 0;
                    for (int k = i - 1; k <= i + 1; k++)
                    {
                        for (int l = j - 1; l <= j + 1; l++)
                        {
                            if (k >= 0 && k < 49 && l >= 0 && l < 49)
                            {
                                sum += arry[k, l];
                                count++;
                            }
                        }
                    }
                    filteredArry[i, j] = sum / count;
                }
            }


            for (int i = 0; i < 49; i++)
            {

                for (int j = 0; j < 49; j++)
                {
                    Console.Write(filteredArry[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
