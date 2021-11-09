using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konverteraren.Converters;


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
                            Console.WriteLine("BrittishMenu.Menu();");
                            //BrittishMenu.Menu();
                            break;
                        case 3:
                            Lines.Line();
                            Console.WriteLine("AmericanMenu.Menu();");
                          //AmericanMenu.Menu();
                            break;
                        case 4:
                            Lines.Line();
                            Console.WriteLine("1DecInGram.Menu();");
                            //1DecInGram.Menu();
                            break;
                        case 5:
                            Lines.Line();
                            Console.WriteLine("OldSwedishMeassurements.Menu();");
                            //OldSwedishMeassurements.Menu();
                            break;
                        default: 
                            throw new ArgumentOutOfRangeException("Unknown value");
                }
                




            }
        }
    }
}
