using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"\t\tTask 1\nArea = {Math.PI * Math.Pow(radius, 2)}"); // first task
            Console.WriteLine("\t\tTask 2");//second task
            Random rnd = new Random();
            int random = rnd.Next(0, 10);
            int number;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine($"Result: {(number == random ? "You guessed number" : "You didn't guess number")}");
            }
            Console.WriteLine("\t\tTask 3");//third task
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter coordinate X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter coordinate Y: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\tPress any key...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x - 1, y - 1);
            for (int j = 0; j < length; j++)
            {
                Console.Write("*");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < height - 2; i++)
            {
                Console.SetCursorPosition(x - 1, y + i);
                Console.WriteLine("*");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < height - 2; i++)
            {
                Console.SetCursorPosition(x - 2 + length, y + i);
                Console.WriteLine("*");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(x - 1, y - 2 + height);
            for (int j = 0; j < length; j++)
            {
                Console.Write("*");
            }
            Console.ResetColor();
            Console.WriteLine("\t\tPress any key...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t\tTask 4");//fourth task
            Console.Write("Enter number of employees: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter working hours of the first employee: ");
            int m = int.Parse(Console.ReadLine());
            int FullTime = 0;
            for (int i = 0; i < N; i++)
            {
                FullTime += m * 60 + i * 10;
            }
            Console.WriteLine($"Whole team worked for {FullTime / 60} hours and {FullTime % 60} minutes");
            Console.WriteLine("\t\tTask 5");//fifth task
            int num = 0;
            do
            {
                Console.Write("Enter number of triangles (1 - 6): ");
                num = int.Parse(Console.ReadLine());
            } while (num < 1 || num > 6);
            for (int i = 0; i < num; i++)
            {
                for (int k = 0; k < num; k++)
                {
                    for (int j = 0; j < num - 1 - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 2 * (i + 1) - 1; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 0; j < num - 1 - i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}

