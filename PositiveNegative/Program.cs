using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada numbrit
            //programm kontrollib numbrit
            //kui number on positiivne, konsool kuvab "number on positiivne";
            //kui number on negatiivne, konsool kuvab "number on negatiivne";
            //Kui sisestatud number on 0, siis konsool kuvab "null";
            //NB! Int32.Parse asemel kasutame Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write Number Yes Yes");

            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number < 0)
            {
                Console.WriteLine("The Number Is Negative");
            }

           else if (Number > 0)
            {
                Console.WriteLine("The Number Is Positive");
            }

            else
            {
                Console.WriteLine("The Number Is Zero");
            }



        }
    }
}
