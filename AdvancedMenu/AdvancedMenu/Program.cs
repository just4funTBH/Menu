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
        }
        static void DisplayMenu()
        {
            Console.WriteLine("*************************************Menu***************************************");
            Console.WriteLine("Treffen Sie ihre Wahl!");
            Console.WriteLine("\n  1 \t Erste Aufgabe - Casino");
            Console.WriteLine("\n  2 \t Zweite Aufgabe - Bankomat");
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
        static bool Code()
        {
            Console.WriteLine("Geben Sie ihren Code an");
            string compare = Console.ReadLine();

            if(compare == "1234")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Falscher Code");
                Console.ReadLine();
                return false;
            }
        }
        static void DisplaySecondMenu()
        {
            Console.WriteLine("*************************************Menu***************************************");
            Console.WriteLine("Treffen Sie ihre Wahl!");
            Console.WriteLine("\n  1 \t Guthaben abfragen");
            Console.WriteLine("\n  2 \t Geld abheben");
            Console.WriteLine("\n  3 \t Vorgang abbrechen");
            Console.WriteLine("\n********************************************************************************");
        }
        static void ExecuteSecondMenu()
        {
            while (true)
            {
                char c = Console.ReadKey().KeyChar;

                switch (c)
                {
                    case '1':
                        Console.WriteLine("");
                        break;
                    case '2':
                        Console.WriteLine("");
                        break;
                    case '3':
                        Console.WriteLine("Vorgang wurde abgebrochen!");
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe");
                        break;
                }
                if (c == '3')
                {
                    break;
                }
                Console.Clear();
            }
        }
        static void ShowBalance(double kontostand)
        {
            Console.WriteLine(kontostand);
        }
        static double Withdraw(double kontostand, double betrag)
        {
            kontostand -= betrag;
            return kontostand;
        }
    }
}
