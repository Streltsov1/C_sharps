using System;
using System.Text;

namespace Array_Multidimensional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine("Завдання 1");
            Console.Write("Введіть розмір масиву: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, 10);
            }
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Array.Sort(array);
            Console.WriteLine($"Мінімалтне значення в масиві: {array[0]}\nМаксимальне значення в масиві: {array[size - 1]}");
            Console.WriteLine("Завдання 2");
            int num = array[0];
            bool found = false;
            for (int i = 1; i < size; i++)
            {
                if (num == array[i])
                {
                    found = true;
                    break;
                }
                num = array[i];
            }
            Console.WriteLine($"Результат: {(found ? "У масиві є однакові елементи" : "У масиві немає однакових елементів")}");
            Console.WriteLine("Завдання 3");
            Console.Write("Введіть розмір масиву: ");
            int size1 = int.Parse(Console.ReadLine());
            int[] array1 = new int[size1];
            for (int i = 0; i < size1; i++)
            {
                array1[i] = rnd.Next(0, 10);
            }
            foreach (var item in array1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            int count = 0;
            double avg = 0;
            for (int i = 0; i < size1; i++)
            {
                if ((i % 2) == 0 && (array1[i] % 2) == 0)
                {
                    count++;
                    avg += array1[i];
                }
            }
            Console.WriteLine($"Середнє арефметичне значення: {avg / count}");
            Console.WriteLine("Завдання 4");
            Console.Write("Введіть розмір масиву: ");
            int size2 = int.Parse(Console.ReadLine());
            int[] array2 = new int[size2];
            for (int i = 0; i < size2; i++)
            {
                array2[i] = rnd.Next(-10, 10);
            }
            foreach (var item in array2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            count = 0;
            int[] new_array = new int[0];
            foreach (var item in array2)
            {
                if ((item % 2) == -1)
                {
                    count++;
                    Array.Resize(ref new_array, count);
                    Array.Fill(new_array, item, count - 1, 1);
                }
            }
            Console.Write("Непарні значення менші нуля: ");
            foreach (var item in new_array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine("Завдання 5");
            Console.Write("Введіть розмір масиву: ");
            int size_all = int.Parse(Console.ReadLine());
            int[] array_a = new int[size_all];
            int[] array_b = new int[size_all];
            int[] array_c = new int[size_all];
            for (int i = 0; i < size_all; i++)
            {
                array_a[i] = rnd.Next(10, 30);
                array_b[i] = rnd.Next(10, 30);
            }
            for (int i = 0; i < size_all; i++)
            {
                array_c[i] = (array_a[i] + array_b[i]);
            }
            Console.Write("Масив А: ");
            foreach (var item in array_a)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\nМасив Б: ");
            foreach (var item in array_b)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\nМасив В: ");
            foreach (var item in array_c)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
