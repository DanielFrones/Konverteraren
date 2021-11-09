using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Konverteraren.Menus
{
    class WelcomeMenu
    {
        static public void Welcome()
        {

            Console.WriteLine("Hej och välkommen till Konverteraren(TRADEMARK!!!), här tillhandahåller vi varenda konvertering under solen!");
            Console.WriteLine("Du kommer få välja typ av enhetsområde, och i steget efter vilka enheter du vill konvertera.");

            Console.WriteLine("Tryck på valfri knapp för att fortsätta:");

            Console.ReadKey();
          
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\n");
            
            Lines.Line();

        }

    }
}
