using System;
using System.Text;

namespace Файлик
{
    public class Program
    { 
        public static string ConvertCase(string input)  //это чтобы изменить регистр буковки
    {
        if (string.IsNullOrEmpty(input))  //проверяем, чтобы строка не была пуста
        {
            return input; 
        }

        StringBuilder a = new StringBuilder();
        foreach (char c in input)
        {
            if (char.IsLower(c))
            {
                a.Append(char.ToUpper(c));
            }
            else if (char.IsUpper(c))
            {
                a.Append(char.ToLower(c));
            }
            else
            {
                a.Append(c); 
            }
        }
        return a.ToString();
    }
    
        static void Main(string[] args)
        {
            /*Задание 1. Выведите на экран информацию о каждом типе данных в виде:
            Тип данных – максимальное значение – минимальное значение*/
            Console.WriteLine("Задание 1");
            
            Console.WriteLine("Тип данных - Максимальное значение - Минимальное значение");
            Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
            Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
            Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
            Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
            Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
            Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
            Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");
            Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
            Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
            Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");
            Console.WriteLine($"char - {(int)char.MaxValue} - {(int)char.MinValue}"); //преобразуем в инт, чтобы вывести именно числовое значение
            Console.ReadLine();


            /*Задание 2. Напишите программу, в которой принимаются данные пользователя в виде имени,
            города, возраста и PIN-кода. Далее сохраните все значение в соответствующей
            переменной, а затем распечатайте всю информацию в правильном формате.*/
            Console.WriteLine("Задание 2");

            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите ваш город");
            string city = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст");
            int? age = null;
            try  // пользователь - дурак, а нам нужно интовое значение
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка формата, попробуйте еще раз");
                Console.WriteLine();
                try
                {
                    Console.WriteLine("Введите ваш возраст");
                    age = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Цифрами пиши");
                    Console.WriteLine();
                    try
                    {
                        Console.WriteLine("Введите ваш возраст");
                        age = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Попытки кончились, дурень");
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine("Введите ваш PIN-код");
            string pincode = Console.ReadLine();

            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Город: {city}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"PIN-код: {pincode}");
            Console.ReadLine();


            /*Задание 3. Преобразуйте входную строку: строчные буквы замените на заглавные, 
              заглавные – на строчные*/
            Console.WriteLine("Задание 3");

            Console.WriteLine("Введите строку");
            string strochka = Console.ReadLine();
            string changedStrochka = ConvertCase(strochka); 
            Console.WriteLine($"Преобразованная строка: {changedStrochka}");
            Console.ReadLine();


            /*Задание 4. Введите строку, введите подстроку
            Необходимо найти количество вхождений и вывести на экран*/
            Console.WriteLine("Задание 4");
            
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();

            while (true) // нам обязательно, чтобы строка была введена
            {
                if (!string.IsNullOrEmpty(stroka)) //проверяем, а не пустая ли наша строка
                {
                    break;
                }
                else
                {
                    Console.Write("Нужно ввести строку");
                    Console.WriteLine();
                    stroka = Console.ReadLine();

                }
            }
            Console.Write("Введите подстроку: ");
            string podstroka = Console.ReadLine();
            while (true)
            {
                if (!string.IsNullOrEmpty(podstroka))
                {
                    break;
                }
                else
                {
                    Console.Write("Нужно ввести подстроку");
                    Console.WriteLine();
                    podstroka = Console.ReadLine();

                }
            }

            int count = 0;
            int index = 0;

            while ((index = stroka.IndexOf(podstroka, index, StringComparison.OrdinalIgnoreCase)) != -1) //делаем независимость от регистра
            {
                count++;
                index += podstroka.Length;
            }

            Console.WriteLine($"Количество вхождений подстроки: {count}");
            Console.ReadLine();
            }
        }
    }

