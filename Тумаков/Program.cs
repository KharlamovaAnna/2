using System;

namespace Тумаков
{
    public struct BankAcc
    {
        public long AccNumber;
        public BankAccType AccType;
        public decimal AccBalance;
    }
    public enum BankAccType
    {
        Текущий,
        Сберегательный
    }
    public enum Uni 
    {
        КГУ,
        КАИ,
        КХТИ
    }
    public struct Employee
    {
        public string Name;
        public Uni WorkPlace;
    }
 
        public class Program
    {
        static void Main(string[] args)
        {
            /*Задание 1. Создать перечислимый тип данных отображающий виды банковского счета(текущий и сберегательный)
            Создать переменную типа перечисления, присвоить ей значение и вывести это значение на печать*/
            Console.WriteLine("Упражнение 3.1");
            BankAccType AccType;
            AccType = BankAccType.Сберегательный;  //используем созданный енам
            Console.WriteLine($"Тип банковского счета: {AccType}");
            Console.ReadLine();


            /*Задание 2. Создать структуру данных, которая хранит информацию о банковском
            счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
            значениями и напечатать результат*/
            Console.WriteLine("Упражнение 3.2");
            BankAcc AccInfo;
            AccInfo.AccNumber = 5438453573845675498;
            AccInfo.AccType = BankAccType.Сберегательный;
            AccInfo.AccBalance = 4858493845m;
            Console.WriteLine($"Номер счета: {AccInfo.AccNumber}");
            Console.WriteLine($"Тип счета: {AccInfo.AccType}");
            Console.WriteLine($"Баланс счета: {AccInfo.AccBalance}");
            Console.ReadLine();


            /*Задание 3.Создать перечислимый тип ВУЗ{ КГУ, КАИ, КХТИ}. Создать
            структуру работник с двумя полями: имя, ВУЗ.Заполнить структуру данными и распечатать*/
            Console.WriteLine("Домашнее задание 3.1");
            Employee EmployeeInfo;
            EmployeeInfo.Name = "Латыпова Дина"; //  ･ᴗ･ 
            EmployeeInfo.WorkPlace = Uni.КГУ;
            Console.WriteLine($"Имя работника: {EmployeeInfo.Name}");
            Console.WriteLine($"Место работы: {EmployeeInfo.WorkPlace}");
            Console.ReadLine();


        }
    }
}
