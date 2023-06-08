using System;

class Program
{
    static bool isMagicSquare(int[] arr, int n)
    {
        int[,] matrix = new int[n, n];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = arr[index];
                index++;
            }
        }
        int mainSum = (1 + arr.Length) * arr.Length / (2 * n);
        int sumRows;
        int sumColumns;
        int sumMainDiagonal = 0;
        int sumSecondaryDiagonal = 0;
        bool f = true;

        //суммы магического квадрата
        for (int i = 0; i < n; i++)
        {
            sumRows = 0;
            sumColumns = 0;
            for (int j = 0; j < n; j++)
            {
                sumRows += arr[(i * n) + j];
                sumColumns += arr[(j * n) + i];
                if (i == j) sumMainDiagonal += matrix[i, j];
                if (j == n - i - 1) sumSecondaryDiagonal += matrix[i, j];
            }
            if (sumRows != mainSum || sumColumns != mainSum) return !f;
        }
        if (sumMainDiagonal != mainSum || sumSecondaryDiagonal != mainSum) return !f;
        return f;
    }
    static void Main()
    {
        int n = 3;
        int[] Square = new int[n * n];
        Random rand = new Random();
        int k = 0;

        do
        {
            for (int i = 0; i < Square.Length; i++)
            {
                bool notUnique = false;
                Square[i] = rand.Next(1, 10);
                for (int j = 0; j < i; j++)
                {
                    if (Square[j] == Square[i])
                    {
                        notUnique = true;
                        break;
                    }
                }
                if (notUnique) i--;
                
            }
                k++;
                Console.WriteLine(k);
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //        Console.Write(Square[(i * n) + j] + " ");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
        } while (!isMagicSquare(Square, n));

        Console.WriteLine("количество переборов: " + k);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(Square[(i * n) + j] + " ");
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
