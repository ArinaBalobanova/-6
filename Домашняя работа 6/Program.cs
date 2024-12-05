using System;
using HomeWork.Classes;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
        
        static void Task1()
        {
            /*Упражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс,
            тип банковского счета (использовать перечислимый тип из упр. 3.1). Предусмотреть методы для доступ
            к данным – заполнения и чтения. Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.*/
            {
                Console.WriteLine("Лабораторная 7.1");
                BankAccount myAccount = new BankAccount("25838275024", 2500, AccountType.Savings);
                myAccount.PrintAccountInfo();
            }
        }
        static void Task2()
        {
            /*Упражнение 7.2 Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы номер счета
            генерировался сам и был уникальным. Для этого надо создать в классе статическую переменную и метод,
            который увеличивает значение этого переменной.*/
            Console.WriteLine("Лабораторная 7.2");
            BankAccount2 myAccount = new BankAccount2(2500, AccType.Current);
            myAccount.PrintAccountInfo();
        }
        static void Task3()
        {
            /*Упражнение 7.3 Добавить в класс счет в банке два метода: снять со счета и положить на счет.
            Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае положительного результата изменяет баланс.*/
            Console.WriteLine("Лабораторная 7.3");
            BankAccount3 myAccount = new BankAccount3(2500, AccType.Current);
            myAccount.Deposit(500);
            myAccount.Withdraw(400);
            myAccount.PrintAccountInfo();
        }
        static void Task4()
        {
            /*Домашнее задание 7.1 Реализовать класс для описания здания (уникальный номер здания, высота, этажность,
            количество квартир, подъездов). Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения
            значений полей для печати. Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества 
            квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания генерировался программно.
            Для этого в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания,
            и предусмотреть метод, который увеличивал бы значение этого поля.*/
            Console.WriteLine("Домашнее задание 7.1");
            BuldingParameters building = new BuldingParameters(45, 17, 54, 2);
            building.PrintBuildingInfo();
            Console.WriteLine($"Высота этажа: {building.FloorHeight()}");
            Console.WriteLine($"Количество квартир в подъезде: {building.ApartmentsPerEntrance()}");
            Console.WriteLine($"Количество квартир на этаже: {building.ApartmentsPerFloor()}");

        }
    }
}