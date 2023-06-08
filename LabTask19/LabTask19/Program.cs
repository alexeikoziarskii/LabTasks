using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте размерность квадратной матрицы");
            string dim;
            int n;
            Console.Write("n: ");
            dim = Console.ReadLine();
            while (!int.TryParse(dim, out n))
            {
                Console.WriteLine("повторите ввод");
                Console.Write("n: ");
                dim = Console.ReadLine();
            }

            int[,] arr = new int[n, n];
            Random rand = new Random();
            Console.WriteLine("исходный массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        arr[i, j] = i;
                    else if (j == n - i - 1)
                        arr[i, j] = j;
                    else 
                        arr[i, j] = rand.Next(10);
                    Console.Write("{0, 3}", arr[i, j]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
