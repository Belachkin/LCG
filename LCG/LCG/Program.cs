using System;
using static System.Console;

namespace LCG
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorConsole.WriteWrappedHeader("Выполнил студент ИБ-4118-О Белкин Д А \n\nЛабораторная работа №3\n\nШифрование методом гаммирования.Генерация псевдослучайных чисел");

            for (; ; )
            {
                ColorConsole.WriteEmbeddedColorLine("\nВводите значения через запятую избегая пробелов. [yellow]LGC(m, ^m, -m, a, b, g0)[/yellow]\n");

                WriteLine("под ^m подразумевается степень числа m, а под -m что отнять например m, ^m, -m -> 2^31-1\n");

                ColorConsole.WriteEmbeddedColorLine("Введите по одному из шаблонов [yellow]m,^m,-m,a,b,g0[/yellow] | [yellow]m,^m,a,b,g0[/yellow] | [yellow]m,a,b,g0[/yellow]");
                try
                {
                    string input = Console.ReadLine();
                    string[] inputSplit = input.Split(',');

                    WriteLine("");
                    if (inputSplit.Length > 6)
                    {
                        ColorConsole.WriteLine("Вы ввели больше 6х значений", ConsoleColor.Red);
                    }
                    else if (inputSplit.Length < 4)
                    {
                        ColorConsole.WriteLine("Вы ввели меньше 4х значений", ConsoleColor.Red);
                    }
                    else
                    {
                        LCG(inputSplit);
                        ReadKey();
                    }
                }
                catch (Exception ex)
                {
                    ColorConsole.WriteLine(ex.Message, ConsoleColor.Red);
                }
            }
        }
        public static void LCG(string[] arr)
        {
            int m, mup, minus, a, b, g;
            int temp = 0;
            if (arr.Length == 4)
            {
                m = Convert.ToInt32(arr[0]);
                a = Convert.ToInt32(arr[1]);
                b = Convert.ToInt32(arr[2]);
                g = Convert.ToInt32(arr[3]);


                for (int i = g; i >= 0; i--)
                {
                    if (i == g)
                    {
                        WriteLine($"G{temp} = {g}");

                    }
                    else
                    {
                        WriteLine($"G{temp} = {a} * {g - 1} + {b} |{m}| = { ((a * (g - 1)) + b) * Math.Abs(m)  }");
                        g -= 1;
                    }
                    temp++;
                }
            }
            if (arr.Length == 5)
            {
                m = Convert.ToInt32(arr[0]);
                mup = Convert.ToInt32(arr[1]);
                a = Convert.ToInt32(arr[2]);
                b = Convert.ToInt32(arr[3]);
                g = Convert.ToInt32(arr[4]);


                for (int i = g; i >= 0; i--)
                {
                    if (i == g)
                    {
                        WriteLine($"G{temp} = {g}");

                    }
                    else
                    {
                        WriteLine($"G{temp} = {a} * {g - 1} + {b} |{m}^{mup}| = { ((a * (g - 1)) + b) * Math.Abs(Math.Pow(m, mup))  }");
                        g -= 1;
                    }
                    temp++;
                }
            }
            if (arr.Length == 6)
            {
                m = Convert.ToInt32(arr[0]);
                mup = Convert.ToInt32(arr[1]);
                minus = Convert.ToInt32(arr[2]);
                a = Convert.ToInt32(arr[3]);
                b = Convert.ToInt32(arr[4]);
                g = Convert.ToInt32(arr[5]);


                for (int i = g; i >= 0; i--)
                {
                    if (i == g)
                    {
                        WriteLine($"G{temp} = {g}");

                    }
                    else
                    {
                        WriteLine($"G{temp} = {a} * {g - 1} + {b} |{m}^{mup}-{minus}| = { ((a * (g - 1)) + b) * Math.Abs(Math.Pow(m, mup) - minus)  }");
                        g -= 1;
                    }
                    temp++;
                }
            }
        }
    }
}
