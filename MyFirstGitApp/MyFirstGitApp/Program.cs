using System;

namespace MyFirstGitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа:");
            int firstNumber = 0;
            int secondNumber = 0;
            bool test = true;

            while (test)
            {
                try
                {
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                    secondNumber = Convert.ToInt32(Console.ReadLine());
                    test = false;
                }
                catch
                {
                    Console.WriteLine("Вы ввели не число, попробуйте сного ввести оба числа!");
                    firstNumber = 0;
                    secondNumber = 0;
                }
            }
            Summ(firstNumber, secondNumber);
            Diff(firstNumber, secondNumber);
            Mod(firstNumber, secondNumber);
        }
        public static void Summ(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            Console.WriteLine("Сумма этих числел: " + result);
        }

        public static void Diff(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            Console.WriteLine("Разность этих числел: " + result);
        }

        public static void Mod(double firstNumber, double secondNumber)
        {
            double result = ((double)Math.Abs(firstNumber) + (double)Math.Abs(secondNumber)) / 2;
            Console.WriteLine("Среднее арифметическое их модулей: " + result);
        }
    }
}
