//***************************************************************
//* Практическая работа № 10                                    *
//* Выполнил: Пирогов Д., группа 2ИСП                           *
//* Задание: обработать двухмерный массив                       *
//***************************************************************

using System;

namespace pr10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Практическая работа №10.\nЗдравствуйте!");

            while (true)
            {
                try
                {
                    int M = 3, N = 5;
                    Random rnd = new Random();
                    int[,] Mas = new int[M, N];
                    int product = 1;
                    bool NotEmpty = false;

                    Console.WriteLine("\nХотите ли вы сами ввести элементы матрицы? (Да/Нет).\nЛибо введите команду (Выход), которая завершит работу программы:");
                    string a = Console.ReadLine();

                    if (a == "Выход")
                    {
                        Console.WriteLine("Программа завершена.\nДо свидания!");
                        break;
                    }
                    else if (a == "Да")
                    {
                        Console.WriteLine("Введите элементы матрицы: ");
                        for (int i = 0; i < M; i++) // ввод по строкам
                        {
                            for (int j = 0; j < N; j++) // ввод по столбцам
                            {
                                Console.Write("Элемент [" + i + "," + j + "]: ");
                                try
                                {
                                    Mas[i, j] = Convert.ToInt32(Console.ReadLine());

                                    if (Mas[i, j] != 0)
                                    {
                                        product *= Mas[i, j];
                                        NotEmpty = true;
                                    }
                                }
                                catch (IndexOutOfRangeException ore)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"\nОшибка ввода \n" + ore.Message);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    j--;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    else if (a == "Нет")
                    {
                        for (int i = 0; i < M; i++)
                        {
                            for (int j = 0; j < N; j++)
                            {
                                Mas[i, j] = rnd.Next(-100, 101);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(Mas[i, j] + "\t");
                                Console.ForegroundColor = ConsoleColor.White;
                                if (Mas[i, j] != 0)
                                {
                                    product *= Mas[i, j];
                                    NotEmpty = true;
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Введите Да или Нет! Либо Выход. (Ввод ответа требуется с большой буквы)");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    if (NotEmpty)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Произведение ненулевых элементов: " + product);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                catch (FormatException fe)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nОшибка ввода \n" + fe.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nОшибка ввода \n" + e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
