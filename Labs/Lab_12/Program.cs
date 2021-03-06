using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Program
    {
        private static WrongNumberException WrongNumberEx = new WrongNumberException("WrongNumberFormat");
        private static WrongNumberException WrongCommandEx = new WrongNumberException("WrongRotationIndex");

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа номер 12");
            Console.WriteLine("Введите цифру от (1-5) для выбора задачи: ");

            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:

                    Console.Write(" - задание \n");
                    string[] days = new string[] { "null", "первое", "второе", "третье", "четвертое", "пятое", "шестое", "седьмое", "восьмое", "девятое", "десятое", "одиннадцатое", "двенадцатое", "тринадцатое", "четырнадцатое", "пятнадцатое", "шестнадцатое", "семнадцатое", "восемнадцатое", "девятнадцатое", "двадцатое", "двадцать первое", "двадцать второе", "двадцать третье", "двадцать четвертое", "двадцать пятое", "двадцать шестое", "двадцать седьмое", "двадцать восьмое", "двадцать девятое", "тридцатое", "тридцать первое" };
                    string[] months = new string[] { "null", "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
                    Console.Write("Введите номер дня [1;31] - ");
                    bool isDay = byte.TryParse(Console.ReadLine(), out byte day);
                    Console.Write("Введите номер месяца [1;12] - ");
                    bool isMonth = byte.TryParse(Console.ReadLine(), out byte month);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isDay == false || isMonth == false || day > 31 || day < 1 || month > 12 || month < 1)
                    {
                        throw WrongNumberEx;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"{days[day]} {months[month]}");
                    Console.ResetColor(); // сбрасываю цвета консоли

                    Console.BackgroundColor = ConsoleColor.Blue;  //меняю цвет фона текста
                    Console.ForegroundColor = ConsoleColor.Black; // меняю цвет фона текста
                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ResetColor(); //сбрасываю цвета консоли
                    Console.ReadLine(); // запрашиваю ввод
                    Console.Clear(); // очищаю консоль
                    Main(args); // перезапускаю программу
                    break;

                case ConsoleKey.D2:

                    Console.Write(" - задание \n");
                    string[] compasDir = new string[] { "С", "В", "Ю", "З"};
                    Console.Write("Введите исходное направление робота - ");
                    string startPos = Console.ReadLine();
                    Console.Write("Введите команду - ");
                    string command = Console.ReadLine();
                    int commandIndex = Convert.ToInt32(command);

                    if (compasDir.Contains(startPos) == false)//вызываю собственные ошибки при нарушении правил ввода
                    {
                        throw WrongNumberEx;
                    }

                    string newPos;
                    if (commandIndex == 0)
                    {
                        newPos = startPos;
                    }
                    else if (commandIndex == 1)
                    {
                        if (startPos == "С")
                        {
                            newPos = compasDir[3];
                        }
                        else
                        {
                            newPos = compasDir[Array.IndexOf(compasDir, startPos) - commandIndex];
                        }
                    }
                    else if (commandIndex == -1)
                    {
                        if (startPos == "З")
                        {
                            newPos = compasDir[0];
                        }
                        else
                        {
                            newPos = compasDir[Array.IndexOf(compasDir, startPos) + (-commandIndex)];
                        }
                    }
                    else
                    {
                        throw WrongCommandEx;
                    }

                    Console.ForegroundColor = ConsoleColor.Red;//меняю цвет текста
                    Console.WriteLine($"Новое направление робота {newPos}");
                    Console.ResetColor(); // сбрасываю цвета консоли

                    Console.BackgroundColor = ConsoleColor.Blue;  //меняю цвет фона текста
                    Console.ForegroundColor = ConsoleColor.Black; // меняю цвет фона текста
                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ResetColor(); //сбрасываю цвета консоли
                    Console.ReadLine(); // запрашиваю ввод
                    Console.Clear(); // очищаю консоль
                    Main(args); // перезапускаю программу
                    break;

                case ConsoleKey.D3:
                    
                    Console.Write(" - задание \n");
                    string[] taskNumbers = new string[] {"", "", "", "", "", "", "", "", "", "", "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать", "двадцать", "двадцать одно", "двадцать два", "двадцать три", "двадцать четыре", "двадцать пять", "двадцать шесть", "двадцать семь", "двадцать восемь", "двадцать девять", "тридцать", "тридцать одно", "тридцать два", "тридцать три", "тридцать четыре", "тридцать пять", "тридцать шесть", "тридцать семь", "тридцать восемь", "тридцать девять", "сорок"};
                    string bufText = "учебных заданий";
                    Console.Write("Введите кол-во заданий - ");
                    bool isNumb = byte.TryParse(Console.ReadLine(), out byte number);
                    
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isNumb == false || number < 10 || number > 40)
                    {
                        throw WrongNumberEx;
                    }

                    if (number == 21 || number == 31)
                    {
                        bufText = "учебное задание";
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"{taskNumbers[number]} {bufText}");
                    Console.ResetColor(); // сбрасываю цвета консоли

                    Console.BackgroundColor = ConsoleColor.Blue;  //меняю цвет фона текста
                    Console.ForegroundColor = ConsoleColor.Black; // меняю цвет фона текста
                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ResetColor(); //сбрасываю цвета консоли
                    Console.ReadLine(); // запрашиваю ввод
                    Console.Clear(); // очищаю консоль
                    Main(args); // перезапускаю программу
                    break;

                case ConsoleKey.D4:

                    Console.Write(" - задание \n");
                    string[] numbers3 = new string[] {"", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот"};
                    string[] numbers2 = new string[] {"", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семдесят", "восемдесять", "девяносто"};
                    string[] numbers1 = new string[] {"", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять"};
                    string[] numbers11 = new string[] {"", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"};
                    Console.Write("Введите число [100-999] - ");
                    bool isNumber = int.TryParse(Console.ReadLine(), out int numb);

                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isNumber == false || numb < 100 || numb > 999)
                    {
                        throw WrongNumberEx;
                    }

                    if ((numb % 100) > 10 && (numb % 100) < 20)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                        Console.WriteLine($"{numbers3[numb / 100]} {numbers11[numb % 10]}");
                        Console.ResetColor(); // сбрасываю цвета консоли
                    }
                    else if (((numb % 100) > 19 || (numb % 100) == 10) && (numb % 100) < 100)
                    {
                        if ((numb%10) == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                            Console.WriteLine($"{numbers3[numb / 100]} {numbers2[(numb / 10) % 10]}");
                            Console.ResetColor(); // сбрасываю цвета консоли
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                            Console.WriteLine($"{numbers3[numb / 100]} {numbers2[(numb / 10) % 10]} {numbers1[numb % 10]}");
                            Console.ResetColor(); // сбрасываю цвета консоли  
                        }
                    }
                    else if (((numb / 10) % 10) == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                        Console.WriteLine($"{numbers3[numb / 100]} {numbers1[numb % 10]}");
                        Console.ResetColor(); // сбрасываю цвета консоли  
                    }

                    Console.BackgroundColor = ConsoleColor.Blue;  //меняю цвет фона текста
                    Console.ForegroundColor = ConsoleColor.Black; // меняю цвет фона текста
                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ResetColor(); //сбрасываю цвета консоли
                    Console.ReadLine(); // запрашиваю ввод
                    Console.Clear(); // очищаю консоль
                    Main(args); // перезапускаю программу
                    break;


                case ConsoleKey.D5:

                    Console.Write(" - задание \n");
                    Console.Write("Введите год - ");
                    bool isYear = int.TryParse(Console.ReadLine(), out int year);
                    
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isYear == false || year < 0)
                    {
                        throw WrongNumberEx;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    switch ((year) % 10)
                    {
                        case 0:
                        case 1:
                            Console.Write("белый");
                            break;
                        case 2:
                        case 3:
                            Console.Write("черный");
                            break;
                        case 4:
                        case 5:
                            Console.Write("зелёный");
                            break;
                        case 6:
                        case 7:
                            Console.Write("красный");
                            break;
                        case 8:
                        case 9:
                            Console.Write("жёлтый");
                            break;
                        default:
                            break;
                    }

                    Console.Write(" год ");

                    switch ((year + 8) % 12)
                    {
                        case 0:
                            Console.Write("крысы");
                            break;
                        case 1:
                            Console.Write("коровы");
                            break;
                        case 2:
                            Console.Write("тигра");
                            break;
                        case 3:
                            Console.Write("зайца");
                            break;
                        case 4:
                            Console.Write("дракона");
                            break;
                        case 5:
                            Console.Write("змеи");
                            break;
                        case 6:
                            Console.Write("лошади");
                            break;
                        case 7:
                            Console.Write("овцы");
                            break;
                        case 8:
                            Console.Write("обезьяны");
                            break;
                        case 9:
                            Console.Write("курицы");
                            break;
                        case 10:
                            Console.Write("собаки");
                            break;
                        case 11:
                            Console.Write("свиньи");
                            break;
                        default:
                            break;
                    }
                    Console.ResetColor(); //сбрасываю цвета консоли

                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Blue;  //меняю цвет фона текста
                    Console.ForegroundColor = ConsoleColor.Black; // меняю цвет фона текста
                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ResetColor(); //сбрасываю цвета консоли
                    Console.ReadLine(); // запрашиваю ввод
                    Console.Clear(); // очищаю консоль
                    Main(args); // перезапускаю программу
                    break;

                default:
                    break;
            }
        }
    }
}
