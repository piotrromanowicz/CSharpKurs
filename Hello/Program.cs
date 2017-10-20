using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (;;)
            {
                Greeting();
                Age();
                Setting();
            }
        }

        /// <summary>
        /// max i min wartości zmiennych
        /// </summary>
        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("max wartość int: " + maxInt);
            Console.WriteLine("min wartość int: " + minInt);
            Console.WriteLine("max wartość float: " + maxFloat);
            Console.WriteLine("min wartość float: " + minFloat);
            Console.WriteLine("max wartość long: " + maxLong);
            Console.WriteLine("min wartość long: " + minLong);
        }

        /// <summary>
        /// ustawienia
        /// </summary>
        private static void Setting()
        {
            Console.ResetColor();
            Console.WriteLine("Naciśnij dowolny klawisz");
            Console.ReadKey();
            Console.Clear();
        }
        
        /// <summary>
        /// sprawdzenie wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("Write, how old are you ? ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Złe dane");
            }
            else if (age < 18)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You can drink milk only.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You can drink beer and wine.");
            }
        }
        
        /// <summary>
        /// powitanie 
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Write, What your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);
        }
    }
}
