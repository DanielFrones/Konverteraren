using Konverteraren.Converters;
using System;

namespace Konverteraren.Menus
{
    public class BrittishMenu
    {
        public static void Menu()
        {

            Console.WriteLine("Välj Konverterare genom att trycka på ett nummer: ");
            Console.WriteLine("1. Gallon - Liter");
            Console.WriteLine("2. Liter - Gallon");
            Console.WriteLine("3. Pint - Deciliter");
            Console.WriteLine("4. Deciliter - Pint");
            Console.WriteLine("5. Cup - Deciliter");
            Console.WriteLine("6. Deciliter - Cup");
            Console.WriteLine("7. UK fluid ounce - Milliliter");
            Console.WriteLine("8. Milliliter - UK fluid ounce");
            Console.WriteLine("9. Tablespoon - Milliliter");
            Console.WriteLine("10. Milliliter - Tablespoon");
            Console.WriteLine("11. Teaspoon - Milliliter");
            Console.WriteLine("12. Milliliter - Teaspoon");
            Console.WriteLine("13. Pound - Kilo");
            Console.WriteLine("14. Kilo - Pound");


            int userInput = Convert.ToInt32(Console.ReadLine());


            switch (userInput)
            {
                case 1:
                    Brittish.GallonToLiter();
                    break;
                case 2:
                    Brittish.LiterToGallon();
                    break;
                case 3:
                    Brittish.PintToDeciliter();
                    break;
                case 4:
                    Brittish.DeciliterToPint();
                    break;
                case 5:
                    Brittish.CupToDeciliter();
                    break;
                case 6:
                    Brittish.DeciliterToCup();
                    break;
                case 7:
                    Brittish.OunceToMilliliter();
                    break;
                case 8:
                    Brittish.MilliliterToOunce();
                    break;
                case 9:
                    Brittish.TablespoonToMilliliter();
                    break;
                case 10:
                    Brittish.MilliliterToTablespoon();
                    break;
                case 11:
                    Brittish.TeaspoonToMilliliter();
                    break;
                case 12:
                    Brittish.MilliliterToTeaspoon();
                    break;
                case 13:
                    Brittish.PoundToKilo();
                    break;
                case 14:
                    Brittish.KiloToPound();
                    break;
                default:
                    Console.WriteLine("Felaktig val");
                    break;

            }

        }
    }

}