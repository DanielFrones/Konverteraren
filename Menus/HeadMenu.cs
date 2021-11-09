﻿using System;


namespace Konverteraren.Menus
{
    class HeadMenu
    {

        public static void Menu()
        {
            {

                Console.WriteLine("Välj vilket område för enhetstyp du vill konvertera: ");
                Console.WriteLine("1. Svenska mått");
                Console.WriteLine("2. Brittiska mått");
                Console.WriteLine("3. Amerikanska mått");
                Console.WriteLine("4. 1 deciliter i gram");
                Console.WriteLine("5. Gamla svenska mått");




                int userInput = Convert.ToInt32(Console.ReadLine());



                switch (userInput)
                {
                    case 1:
                        Lines.Line();
                        SwedishMenu.Menu();
                        break;
                    case 2:
                        Lines.Line();
                        BrittishMenu.Menu();
                        
                        break;
                    case 3:
                        Lines.Line();
                        AmericanMenu.AmericanMenuMethod();
                        
                        break;
                    case 4:
                        Lines.Line();
                        IngridientMenu.Menu();
                        
                        break;
                    case 5:
                        Lines.Line();
                        OldSwedish.OldSwedishMenu();
                        
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Unknown value");
                }





            }
        }
    }
}
