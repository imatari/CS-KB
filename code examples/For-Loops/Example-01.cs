
using System;

namespace For_Loop_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3 };
            int z = values.Length;
            for (int x = 0, y = z-1;
                ((x < z) && (y >= 0));
                x++, y--)
            {
                Console.Write(values[x]);
                Console.Write(values[y]);
            }
            Console.WriteLine();
        }
    }
}
