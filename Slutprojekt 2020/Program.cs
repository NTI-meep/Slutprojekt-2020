using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings, this is the beginning of an very barebone game, enjoy");
            Console.WriteLine("You will be allowed to name your character and can perform three actions");
            Console.WriteLine("Either you rest which restores health - fight normal enemies - or fight the boss which is tougher");

           

            

            string[] items2 = { "Fight", "Rest", "Fight the boss" };
            int selected2 = 0;
            while (true)
            {

                for (int i = 0; i < items2.Length; i++)
                {
                    if (i == selected2) Console.Write(">");
                    else Console.Write(" ");
                    Console.WriteLine(items2[i]);
                }


                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow) selected2--;
                if (key.Key == ConsoleKey.DownArrow) selected2++;
                if (key.Key == ConsoleKey.Enter) break;

                Console.Clear();
                if (selected2 > items2.Length - 1)
                {
                    selected2 = items2.Length - 1;
                }

                if (selected2 < 0)
                {
                    selected2 = 0;
                }

            }




            Console.ReadLine();
        }

    }
}
