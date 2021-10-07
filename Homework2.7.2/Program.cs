using System;

namespace HomeWork2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Антон Петров";
            int Age = 18;
            string Email = "AnPetrov@mail.com";
            int markProgramming = 51;
            int markMath = 47;
            int markPhysics = 69;
            //Console.WriteLine($"Ф.И.О. - {FullName}");
            //Console.WriteLine($"Возраст - {Age}");
            //Console.WriteLine($"Эл. почта - {Email}");
            //Console.WriteLine($"Баллы по программированию - {markProgramming}");
            //Console.WriteLine($"Баллы по математике - {markMath}");
            //Console.WriteLine($"Баллы по физике - {markPhysics}");

            string infoStudent = "Ф.И.О. - {0} \nВозраст - {1} \nЭл. почта - {2}" +
                "\nБаллы по программированию - {3} \nБаллы по математике - {4} \nБаллы по физике - {5}";
            Console.WriteLine(infoStudent,
                                FullName,
                                Age,
                                Email,
                                markProgramming,
                                markMath,
                                markPhysics);
            Console.ReadKey();
            int markSum = markMath + markPhysics + markProgramming;
            double markMedian = Math.Round((double)markSum / 3, 2);

            Console.WriteLine($"\nСумма баллов - {markSum}");
            Console.ReadKey();
            Console.WriteLine($"Средний балл - {markMedian}");
            Console.ReadKey();

        }
    }
}