﻿using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja käest sisestada tema lemmikvärvi;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled autist";

            Console.WriteLine("Mis on su lemmikvärv?");
            string UserColor = Console.ReadLine();

            if (UserColor == "punane")
            {
                Console.WriteLine("Sa oled väga kuri");
            }

           else if (UserColor == "sinine")
            {
                Console.WriteLine("Sa oled depressioonis");
            }

            else if (UserColor == "roheline")
            {
                Console.WriteLine("Sa oled väga rõve");
            }

            else 
            {
                Console.WriteLine("Sa oled autist");
            }









        }
    }
}
