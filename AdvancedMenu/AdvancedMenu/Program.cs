using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
            Casino(ReadAge());
        }
        static void DisplayMenu()
        {
            Console.WriteLine("*************************************Menu***************************************");
            Console.WriteLine("Treffen Sie ihre Wahl!");
            Console.WriteLine("\n  1 \t Erste Aufgabe - Menu");
            Console.WriteLine("\n  2 \t Zweite Aufgabe - Zahlen");
            Console.WriteLine("\n  3 \t Dritte Aufgabe - Das kleine 1x1");
            Console.WriteLine("\n  q \t Quit");
            Console.WriteLine("\n********************************************************************************");
        }
        static void ExecuteMenu()
        {
            while(true)
            {
                char c = Console.ReadKey().KeyChar;
                switch(c)
                {
                    case '1':
                        Console.WriteLine("Sie haben die erste Aufgabe gewählt!");
                        break;
                    case '2':
                        Console.WriteLine("Sie haben die zweite Aufgabe gewählt!");
                        break;
                    case 'q':
                        Console.WriteLine("Auf wiedersehen");
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe");
                        break;
                }
                if (c == 'q')
                {
                    break;
                }
                Console.Clear();
            }
        }
        static int ReadAge()
        {
            int age = 0;

            Console.WriteLine("Herzlich willkommen in unserem Casino");
            Console.WriteLine("Geben Sie ihr alter an!");
            while(!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Ungültige Eingabe");
            }
            return age;
        }
        static void Casino(int age)
        {
            int requiredAge = 18 - age;

            if(age >= 18)
            {
                Console.WriteLine("Viel spaß im Casino!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sie sind zu jung um in unserem Casino spielen zu dürfen. Kommen Sie in " + requiredAge + " Jahren wieder!");
                Console.ReadLine();
            }
        }
    }
}
