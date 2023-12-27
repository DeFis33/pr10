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
                    int M = 3, N = 5; // инициализация размеров двумерного массива
                    Random rnd = new Random(); // создание экземпляра генератора случайных чисел
                    int[,] Mas = new int[M, N]; // инициализация двумерного массива
                    int product = 1; // product - хранение произведения ненулевых элементов матрицы

                    Console.WriteLine("\nХотите ли вы сами ввести элементы матрицы? (Да/Нет).\nЛибо введите команду (Выход), которая завершит работу программы:");
                    string a = Console.ReadLine();

                    if (a == "Выход")
                    {
                        Console.WriteLine("Программа завершена.\nДо свидания!");
                        break;
                    }
                    if (a == "Да") // если пользователь хочет сам ввести элементы матрицы, то
                    {
                        Console.WriteLine("Введите элементы матрицы: ");
                        for (int i = 0; i < M; i++) // ввод по строкам
                        {
                            for (int j = 0; j < N; j++) // ввод по столбцам
                            {
                                Console.Write("Элемент [" + i + "," + j + "]: ");
                                Mas[i, j] = Convert.ToInt32(Console.ReadLine());

                                if (Mas[i, j] != 0) // если Mas[i, j] не равно нулю, то
                                {
                                    product *= Mas[i, j]; // умножение текущего значения product на значение ненулевого элемента, накапливая произведение ненулевых элементов
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    else if (a == "Нет") // иначе, если
                    {
                        for (int i = 0; i < M; i++)
                        {
                            for (int j = 0; j < N; j++)
                            {
                                Mas[i, j] = rnd.Next(-100, 101); // генерация неповторяющихся значений
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(Mas[i, j] + "\t");
                                if (Mas[i, j] != 0)
                                {
                                    product *= Mas[i, j];
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    else // иначе
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Введите Да или Нет! Либо Выход. (Ввод ответа требуется с большой буквы)");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Произведение ненулевых элементов: " + product);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (FormatException e) // частное исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nОшибка ввода \n" + e.Message); // вывод ошибки на экран
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception e) // общее исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nОшибка ввода \n" + e.Message); // вывод ошибки на экран
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
