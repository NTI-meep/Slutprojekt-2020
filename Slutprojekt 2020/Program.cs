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
            Console.WriteLine("First you have to choose a class, either mage or fighter, they both have different cons and pros");
            Console.WriteLine("Fighter do less damage but are sturdier while mages do more damage and are floppier");
            Console.WriteLine("So which one will you go with?");

            string[] items = { "Mage", "Hero" }; 
            int selected = 0;  
            while (true) 
            {

                for (int i = 0; i < items.Length; i++) 
                {
                    if (i == selected) Console.Write(">");   
                    else Console.Write(" ");
                    Console.WriteLine(items[i]);
                }


                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow) selected--;
                if (key.Key == ConsoleKey.DownArrow) selected++;
                if (key.Key == ConsoleKey.Enter) break;

                Console.Clear();
                if (selected > items.Length - 1)   
                {
                    selected = items.Length - 1;
                }

                if (selected < 0)
                {
                    selected = 0;
                }




            }
        }
    }
}
