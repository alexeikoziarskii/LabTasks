using System;
namespace LabTask18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте размерность двумерного массива");
            string dim;
            int n, m;
            Console.Write("n: ");
            dim = Console.ReadLine();
            while (!int.TryParse(dim, out n))
            {
                Console.WriteLine("повторите ввод");
                Console.Write("n: ");
                dim = Console.ReadLine();
            }
            Console.Write("m: ");
            dim = Console.ReadLine();
            while (!int.TryParse(dim, out m))
            {
                Console.WriteLine("повторите ввод");
                Console.Write("m: ");
                dim = Console.ReadLine();
            }

            int[,] arr = new int[n, m];
            Random rand = new Random();
            Console.WriteLine("исходный массив:");
            for (int i = 0; i < n; i++) { 
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rand.Next(10);
                    Console.Write("{0, 3}", arr[i, j]);
                }
            Console.WriteLine("\n");
            }

            Console.WriteLine("с окошком:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(i == 0 || i == n - 1 || j == 0 || j == m - 1)
                        Console.Write("{0, 3}", arr[i, j]);
                    else Console.Write("   ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
