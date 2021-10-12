using System;

namespace _9._3._2
{
    class Program
    {
        public delegate int Sum(int a, int b);
        static void Main(string[] args)
        {
            Sum sum = Sumir;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            sum.Invoke(a, b);
            sum(a, b);
            Console.ReadKey();
        }

        static int Sumir(int a, int b)
        {
            return a - b; 
        }
    }
}
