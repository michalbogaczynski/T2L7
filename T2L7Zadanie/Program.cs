using Microsoft.VisualBasic.FileIO;
using System;
using System.Runtime.CompilerServices;

namespace T2L7Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {        
            //Zadanie 1
            int a = 5;
            int b = 5;
            if (a == b)
            {
                Console.WriteLine($"{a} i {b} są równe");
            }
            else
            {
                Console.WriteLine($"{a} i {b} nie są równe");
            }

            //Zadanie 2
            Console.WriteLine("Zdanie 2\r\nPodaj cyfrę");
            int c = int.Parse(Console.ReadLine());
            if (c % 2 == 0)
            {
                Console.WriteLine($"{c} jest cyfrą parzystą");
            }
            else
            {
                Console.WriteLine($"{c} jest cyfrą nieparzystą");
            }

            //Zadanie 3
            Console.WriteLine("Zdanie 3\r\nPodaj cyfrę");
            int d = int.Parse(Console.ReadLine());
            if (d < 0)
            {
                Console.WriteLine($"{d} jest liczbą ujemną");
            }
            else if (d > 0)
            {
                Console.WriteLine($"{d} jest liczbą dodatnią");
            }
            else
            {
                Console.WriteLine($"{d} jest zerem");
            }

            //Zadanie 4
            Console.WriteLine("Zdanie 4\r\nPodaj rok");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 !=0 || year % 400 == 0)
            {
                Console.WriteLine($"{year} jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine($"{year} nie jest rokiem przestępnym");
            }

            //Zadanie 5
            Console.WriteLine("Zdanie 5\r\nPodaj wiek");
            int age = int.Parse(Console.ReadLine());
            if (age >= 21 && age < 30)
            {
                Console.WriteLine("Możesz zostać posłem");
            }
            else if ( age >= 30 && age < 35)
            {
                Console.WriteLine("Możesz senatorem");
            }
            else if(age >= 35)
            {
                Console.WriteLine("Możesz zostać prezydentem");
            }
            else
            {
                Console.WriteLine("Nie możesz objąć stanowsikam posła, premiera, senatora oraz prezydenta");
            }

            //Zadanie 6
            Console.WriteLine("Podaj wzrost");
            double height = double.Parse(Console.ReadLine());
            if (height > 50 && height <= 150)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else if (height > 150 && height <= 200)
            {
                Console.WriteLine("Jesteś wysoki");
            }
            else if (height > 200)
            {
                Console.WriteLine("Jestęś ogromny");
            }
            else
            {
                Console.WriteLine("Jesteś malutki");
            }

            //Zadanie 7
            Console.WriteLine("Podaj 3 liczby");
            int z = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            if (z > x && z > v)
            {
                Console.WriteLine($"{z} jest największą z podanych");
            }
            else if (x > z && x > v)
            {
                Console.WriteLine($"{x} jest największą z podanych");
            }
            else
            {
                Console.WriteLine($"{v} jest największą z podanych");
            }

            //Zadanie 8
            Console.Write("Podaj wynik matematyki: ");
            int math = int.Parse(Console.ReadLine());
            Console.Write("Podaj wynik fizyki: ");
            int physics = int.Parse(Console.ReadLine());
            Console.Write("Podaj wynik chemii: ");
            int chemisty = int.Parse(Console.ReadLine());
            int total = math + physics + chemisty;

            if (math > 70 && physics > 55 && chemisty > 45 || (math + chemisty > 150) || (math + physics > 150))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else if (total > 180)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
            }

            //Zadanie 9
            Console.Write("Pozdaj temperaturę: ");
            int temperature = int.Parse(Console.ReadLine());
            if (temperature < 0)
            {
                Console.WriteLine("Cholernie piździ");
            }
            else if (temperature >= 0 && temperature < 10)
            {
                Console.WriteLine("Zimno");
            }
            else if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("Chłodno");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("W sam raz");
            }
            else if (temperature >= 30 && temperature < 40)
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("A weź wyprowadzam się na Alaskę");
            }

            //Zadanie 10
            Console.WriteLine("Podaj długość pierwszego boku twójkąta: ");
            int firstSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość drugiego boku twójkąta: ");
            int secondSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość trzeciego boku twójkąta: ");
            int thirdSide = int.Parse(Console.ReadLine());

            if ((firstSide < secondSide + thirdSide) && (secondSide < thirdSide + firstSide) && (thirdSide < firstSide + secondSide))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }

            //Zadanie 11            
            Console.Write("Wpisz ocenę: ");
            int mark = int.Parse(Console.ReadLine());
            switch (mark)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczjący");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Błędna wartość");
                    break;
            }

            //Zadanie 12
            Console.Write("Podaj cyfrę od 1 do 7: ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Wprowadziłeś błędną wartość");
                    break;
            }

            //Zadanie 13
            Console.Write("Podaj pierwszą liczbę: ");
            int firstDigit = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            int secondDigit = int.Parse(Console.ReadLine());
            Console.WriteLine("\r\n 1. Dodawanie \r\n 2. Odejmowanie \r\n 3. Mnożenie \r\n 4. Dzielenie");
            Console.Write("Podaj numer operacji do wykonania: ");
            int calculation = int.Parse(Console.ReadLine());
            int result;
            switch (calculation)
            {
                case 1:
                    result = firstDigit + secondDigit;
                    Console.WriteLine($"Twój wynik to: {result}");
                    break;
                case 2:
                    result = firstDigit - secondDigit;
                    Console.WriteLine($"Twój wynik to: {result}");
                    break;
                case 3:
                    result = firstDigit * secondDigit;
                    Console.WriteLine($"Twój wynik to: {result}");
                    break;
                case 4:
                    if (secondDigit == 0)
                    {
                        Console.WriteLine("Nie dziel przez 0");

                    }
                    else
                    {
                        result = firstDigit / secondDigit;
                        Console.WriteLine($"Twój wynik to: {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Wprowadziłeś błędną wartość");
                    break;
            }
        }
    }
}
