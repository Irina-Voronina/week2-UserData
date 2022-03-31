using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение просит пользователя ввести его год рождения
            //приложение вычисляет возраст пользователя (2022 - год рождения пользователя)
            //если пользователь моложе 18 лет, то в консоли выводится сколько лет и "too young to drive"
            //если пользователь старше 18 лет, то в консоли выводится сколько лет и "drive carefully"
            //если пользователю 18 лет, то в консоли выводится сколько лет и "Congratulations, you may apply
            //for your driving license now"

            Console.WriteLine("Enter your year of birth:");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());


            if (2022 - YearOfBirth < 18)
            {
                Console.WriteLine($"You are {2022 - YearOfBirth} years old, You are too young to drive!");
            }
            else if (2022 - YearOfBirth > 18)
            {
                Console.WriteLine($"You are {2022 - YearOfBirth} years old, Drive carefully!");
            }
            else
            {
                Console.WriteLine($"You are {2022 - YearOfBirth} years old, Congratulations! You may apply for your driving lisence now.");
            }



        }
    }
}
