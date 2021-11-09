using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konverteraren.Converters;

namespace Konverteraren.Menus
{
    class SwedishMenu
    {
        public static void Menu()
        {
           
            int userInput;
            do
            {
                Console.Clear();
                Console.WriteLine("Välj Enheter att konvertera: ");
                Console.WriteLine("1. Liter - Milliliter");
                Console.WriteLine("2. Milliliter - Liter");
                Console.WriteLine("3. Deciliter - Milliliter");
                Console.WriteLine("4. Milliliter - Deciliter");
                Console.WriteLine("5. Centiliter - Milliliter");
                Console.WriteLine("6. Milliliter - Centiliter");
                Console.WriteLine("7. Matsked - Milliliter");
                Console.WriteLine("8. Milliliter - Matsked");
                Console.WriteLine("9. Kryddmått - Milliliter");
                Console.WriteLine("10. Milliliter - Kryddmått");
                Console.WriteLine("11. Kilo - Gram");
                Console.WriteLine("12. Gram - Kilo");
                Console.WriteLine("13. Hekto - Gram");
                Console.WriteLine("14. Gram - Hekto");
                Console.WriteLine("15. Milligram - Gram");
                Console.WriteLine("16. Gram - Milligram");
                userInput = Convert.ToInt32(Console.ReadLine());
                Lines.Line();
            }
            while (userInput == 0 || userInput > 16);
            

            
             
            switch (userInput)
            {
                case 1:
                    Swedish.LitersToMilliliter();
                    break;
                case 2:
                    Swedish.MilliliterToLiter();
                    break;
                case 3:
                    Swedish.DeciliterToMilliliter();
                    break;
                case 4:
                    Swedish.MilliliterToDeciliter();
                    break;
                case 5:
                    Swedish.CentiliterToMilliliter();
                    break;
                case 6:
                    Swedish.MilliliterToCentiliter();
                    break;
                case 7:
                    Swedish.MatskedToMilliliter();
                    break;
                case 8:
                    Swedish.MilliliterToMatsked();
                    break;
                case 9:
                    Swedish.KryddmåttToMilliliter();
                    break;
                case 10:
                    Swedish.MilliliterToKryddmått();
                    break;
                case 11:
                    Swedish.KiloToGram();
                    break;
                case 12:
                    Swedish.GramToKilo();
                    break;
                case 13:
                    Swedish.HektoToGram();
                    break;
                case 14:
                    Swedish.GramToHekto();
                    break;
                case 15:
                    Swedish.MilligramToGram();
                    break;
                case 16:
                    Swedish.GramToMilligram();
                    break;
                
            }

        }

    }
}
