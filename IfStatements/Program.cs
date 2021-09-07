using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //kui kasutaja on vanem, kui 18, siis konsoolis kuvatakse "oled piisavalt vana"
            //kui kasutada on noorem, kui 18, siis konsoolis kuvataksed "oled liiga noor"
            //kui kasutaja on 18, siis kuvatakse "oledki 18"

            Console.WriteLine("Kui vana sa oled?");

            int Age =  Int32.Parse(Console.ReadLine());
            
            if (Age > 18)
            {
                Console.WriteLine("Oled piisavalt vana"); 
            }

            else if (Age < 18)
            {
                Console.WriteLine("oled liiga noor");
            }

            else
            {
                Console.WriteLine("oledgi 18");
            }

            Console.WriteLine("Ilusat päeva!");

        }
    }
}
