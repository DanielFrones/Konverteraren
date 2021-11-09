using Konverteraren.Converters;
using System;
using Konverteraren.Converters;
using Konverteraren.Menus;

namespace Konverteraren.Menus
{
    public class AmericanMenu
    {
        public static void AmericanMenuMethod()
        {





            Console.WriteLine("Välj Konverterare: ");
            Console.WriteLine("1. Gallons - Liter");
            Console.WriteLine("2. Liter - Gallons");
            Console.WriteLine("3. Quart - Deciliter");
            Console.WriteLine("4. Deciliter - Quart");
            Console.WriteLine("5. Pint - Deciliter");
            Console.WriteLine("6. Deciliter - Pint");
            Console.WriteLine("7. Cup - Deciliter");
            Console.WriteLine("8. Deciliter - Cup");
            Console.WriteLine("9. Fluid Ounce - Milliliter");
            Console.WriteLine("10. Milliliter - Fluid Ounce");
            Console.WriteLine("11. Ounce - Gram");
            Console.WriteLine("12. Gram - Ounce");
            Console.WriteLine("13. Pound - Kilo");
            Console.WriteLine("14. Kilo - Pound");





            int userInput = Convert.ToInt32(Console.ReadLine());





            switch (userInput)
            {
                case 1:
                    American.GallonsToLiter();
                    break;



                case 2:
                    American.LitersToGallon();
                    break;



                case 3:
                    American.QuartToDeciliter();
                    break;



                case 4:
                    American.DeciliterToQuart();
                    break;



                case 5:
                    American.PintToDeciliter();
                    break;



                case 6:
                    American.DeciliterToPint();
                    break;




                case 7:
                    American.CupToDeciliter();
                    break;



                case 8:
                    American.DeciliterToCup();
                    break;



                case 9:
                    American.FluidOunceToMililiter();
                    break;



                case 10:
                    American.MililiterToFluidOunce();
                    break;



                case 11:
                    American.OunceToGram();
                    break;



                case 12:
                    American.GramToOunce();
                    break;



                case 13:
                    American.PoundToKilo();
                    break;



                case 14:
                    American.KiloToPound();
                    break;



            }
        }
    }

}