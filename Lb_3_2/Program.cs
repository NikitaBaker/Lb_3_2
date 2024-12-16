using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        double[] numbers = new double[10];
        Console.WriteLine("Введіть 10 чисел:");

        for (int i = 0; i < numbers.Length; i++)
        {
            while (true)
            {
                Console.Write($"Число {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out double num))
                {
                    numbers[i] = num;
                    break;
                }
                else
                {
                    Console.WriteLine("Будь ласка, введіть коректне число.");
                }
            }
        }

        Console.WriteLine("\nЧисла у зворотному порядку:");
        Array.Reverse(numbers);
        Console.WriteLine(string.Join(", ", numbers));

        double maxNum = numbers.Max();
        double minNum = numbers.Min();
        Console.WriteLine($"\nМаксимальне значення: {maxNum}");
        Console.WriteLine($"Мінімальне значення: {minNum}");

 
        double average = numbers.Average();
        Console.WriteLine($"Середнє арифметичне: {average}");

        Console.WriteLine("\nЧисла, більші за середнє арифметичне:");
        var aboveAverage = numbers.Where(num => num > average).ToArray();
        Console.WriteLine(string.Join(", ", aboveAverage));

        Array.Sort(numbers);
        Console.WriteLine("\nЧисла у порядку зростання:");
        Console.WriteLine(string.Join(", ", numbers));
    }
}