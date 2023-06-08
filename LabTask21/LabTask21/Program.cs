using System;
namespace LabTask21
{
    class Program
    {
        static void Main()
        {
            int m, n;
            string size;
            Console.WriteLine("задайте размерность матрицы");
            Console.Write("m: ");
            size = Console.ReadLine();
            while (!int.TryParse(size, out m) || m < 0)
            {
                Console.WriteLine("повторите ввод");
                Console.Write("m: ");
                size = Console.ReadLine();
            }

            Console.Write("n: ");
            size = Console.ReadLine();
            while (!int.TryParse(size, out n) || n < 0)
            {
                Console.WriteLine("повторите ввод");
                Console.Write("n: ");
                size = Console.ReadLine();
            }

            int[,] arr = new int[m, n];
            int val = 1;
            int startX, endX, startY, endY;
            startX = startY = 0;
            endX = n - 1;
            endY = m - 1;
            while (val <= m * n)
            {
                // Вправо
                for (int j = startX; j <= endX; j++)
                {
                    arr[startY, j] = val++;
                }
                startY++;
                if (val > m * n) break;

                // Вниз
                for (int i = startY; i <= endY; i++)
                {
                    arr[i, endX] = val++;
                }
                endX--;
                if (val > m * n) break;

                // Влево
                for (int j = endX; j >= startX; j--)
                {
                    arr[endY, j] = val++;
                }
                endY--;
                if (val > m * n) break;

                // Вверх
                for (int i = endY; i >= startY; i--)
                {
                    arr[i, startX] = val++;
                }
                startX++;
                if (val > m * n) break;
            }

            Console.WriteLine("заполненный по спирали массив:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, 3}", arr[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("повтор?(1, 0)");
            ConsoleKeyInfo r;
            do
            {
                r = Console.ReadKey();
                Console.WriteLine();
            } while ((r.Key != ConsoleKey.D0) && (r.Key != ConsoleKey.D1));
            if (r.Key == ConsoleKey.D1)
            {
                //Console.Clear();
                Main();
            }

        }
    }
}
