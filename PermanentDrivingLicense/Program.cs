using System;

namespace PermanentDrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //pgogramm teatab kasutajat, kas ta on piisavalt vana
            //et juhiluba saada

            Console.WriteLine("Mis on teie sünniaasta?");

            int BirthYear = Int32.Parse(Console.ReadLine());

            int Age = 2021 - BirthYear;

            if (Age > 18) 
            {
                Console.WriteLine("Sa oled piisavalt vana juhiloa jaoks");
            }

            else if (Age < 18)
            {
                Console.WriteLine("Sa ei ole piisavalt vana juhiloa jaoks");
            }

            else
            {
                Console.WriteLine("Sa oled piisavalt vana juhiloa jaoks");
            }



        }
    }
}
