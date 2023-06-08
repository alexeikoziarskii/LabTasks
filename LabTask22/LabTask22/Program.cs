using System;

namespace LabTask22
{
    class Program
    {
        static void Main()
        {
            const int n = 4;
            int[,] arr = { { 2, 5, 6, 9 }, { 5, 3, 7, 6 }, { 6, 7, 3, 5 }, { 9, 6, 5, 2 } };
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("{0, 3}", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            bool isSymmetrical = true;
            for (int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (arr[i, j] != arr[j, i])
                    {
                        isSymmetrical = false;
                        break;
                    }
                    else if (arr[n - 1 - i, j] != arr[i, n - 1 - j])
                    {
                        isSymmetrical = false;
                        break;
                    }

                }
            }
            if(isSymmetrical)
                Console.WriteLine("да");
            else 
                Console.WriteLine("нет");
        }
    }
}
