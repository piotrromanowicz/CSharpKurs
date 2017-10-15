using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine("Witaj " + item);
            }
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(args[0] + " dzisiaj jest " + DateTime.Now.DayOfYear + " dzień roku.");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Liczba " + i);
            }
        }
    }
}
