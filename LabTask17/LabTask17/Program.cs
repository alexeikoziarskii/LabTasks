using System;
namespace LabTask17
{
    class Program
    {
        static void Main()
        {
            Console.Write("введите натуральное число: ");
            uint n;
            string num = Console.ReadLine();
            while(!uint.TryParse(num, out n))
            {
                Console.WriteLine("повторите ввод");
                Console.Write("введите натуральное число: ");
                num = Console.ReadLine();
            }
            uint[] arr = new uint[num.Length];
            for(int i = 0; i < num.Length; i++)
            {
                arr[i] = (uint)(num[i] - '0');
            }
            Array.Sort(arr);
            if(arr[0] == 0)
                for (int i = 0; i < num.Length; i++)
                {
                    if (arr[i] != 0)
                    {
                        uint tmp = arr[0];
                        arr[0] = arr[i];
                        arr[i] = tmp;
                        break;
                    }
                }
            Console.Write("минимальное число из цифр введенного: ");
            foreach (uint i in arr) Console.Write(i);
            Console.WriteLine();

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
