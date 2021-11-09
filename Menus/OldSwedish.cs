using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konverteraren.Menus;
using Konverteraren.Converters;

namespace Konverteraren.Menus
{
    internal class OldSwedish
    {
        public static void OldSwedishMenu()
        {
            Console.WriteLine("Välj vad du vill konvertera: ");
            Console.WriteLine("1. Volym");
            Console.WriteLine("2. Vikt");
            Console.WriteLine("3. Kvantitet");

            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    OldSwedishVolumeMenu();
                    break;
                case 2:
                    OldSwedishWeightMenu();
                    break;
                case 3:
                    OldSwedishQuantityMenu();
                    break;
                default:
                    break;
            }
        }
        public static void OldSwedishVolumeMenu()
        {
            Console.WriteLine("Välj Konverterare: ");
            Console.WriteLine("1. Liter - Spann");
            Console.WriteLine("2. Spann - Liter");
            Console.WriteLine("3. Liter - Kappe");
            Console.WriteLine("4. Kappe - Liter");
            Console.WriteLine("5. Liter - Kanna");
            Console.WriteLine("6. Kanna - Liter");
            Console.WriteLine("7. Deciliter - Kvarter");
            Console.WriteLine("8. Kvarter - Deciliter");
            Console.WriteLine("9. Deciliter - Tekopp");
            Console.WriteLine("10. Tekopp - Deciliter");
            Console.WriteLine("11. Deciliter - Kaffekopp");
            Console.WriteLine("12. Kaffekopp - Deciliter");
            Console.WriteLine("13. Deciliter - Jungfru");
            Console.WriteLine("14. Jungfru . Deciliter");

            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    OldSwedishVolume.LitersToSpann();
                    break;
                case 2:
                    OldSwedishVolume.SpannToLiters();
                    break;
                case 3:
                    OldSwedishVolume.LitersToKappe();
                    break;
                case 4:
                    OldSwedishVolume.KappeToLiters();
                    break;
                case 5:
                    OldSwedishVolume.LitersToKanna();
                    break;
                case 6:
                    OldSwedishVolume.KannaToLiters();
                    break;
                case 7:
                    OldSwedishVolume.DecilitersToKvarter();
                    break;
                case 8:
                    OldSwedishVolume.KvarterToDeciliters();
                    break;
                case 9:
                    OldSwedishVolume.DecilitersToTekopp();
                    break;
                case 10:
                    OldSwedishVolume.TekoppToDeciliters();
                    break;
                case 11:
                    OldSwedishVolume.DecilitersToKaffekopp();
                    break;
                case 12:
                    OldSwedishVolume.KaffekoppToDeciliters();
                    break;
                case 13:
                    OldSwedishVolume.DecilitersToJungfru();
                    break;
                case 14:
                    OldSwedishVolume.JungfruToDeciliters();
                    break;
                default:
                    break;
            }
        }
        public static void OldSwedishWeightMenu()
        {
            Console.WriteLine("Välj konverterare: ");
            Console.WriteLine("1. Gram - Skålpund");
            Console.WriteLine("2. Skålpund - Gram");
            Console.WriteLine("3. Gram - Lod");
            Console.WriteLine("4. Lod - Gram");
            Console.WriteLine("5. Gram - Ort");
            Console.WriteLine("6. Ort - Gram");
            Console.WriteLine("7. Gram - Kvintin");
            Console.WriteLine("8. Kvintin - Gram");

            int userInput = Convert.ToInt32(Console.ReadLine());


            switch (userInput)
            {
                case 1:
                    OldSwedishWeight.GramsToSkålpund();
                    break;
                case 2:
                    OldSwedishWeight.GramsToSkålpund();
                    break;
                case 3:
                    OldSwedishWeight.GramsToLod();
                    break;
                case 4:
                    OldSwedishWeight.LodToGrams();
                    break;
                case 5:
                    OldSwedishWeight.GramsToOrt();
                    break;
                case 6:
                    OldSwedishWeight.OrtToGrams();
                    break;
                case 7:
                    OldSwedishWeight.GramsToKvintin();
                    break;
                case 8:
                    OldSwedishWeight.KvintinToGrams();
                    break;
                default:
                    break;
            }
        }
        public static void OldSwedishQuantityMenu()
        {
            Console.WriteLine("Välj konverterare: ");
            Console.WriteLine("1. Styck - Dussin");
            Console.WriteLine("2. Dussin - Styck");
            Console.WriteLine("3. Styck - Tolft");
            Console.WriteLine("4. Tolft - Styck");
            Console.WriteLine("5. Styck - Tjog");
            Console.WriteLine("6. Tjog - Styck");
            Console.WriteLine("7. Styck - Skock");
            Console.WriteLine("8. Skock - Styck");
            Console.WriteLine("9. Dussin - Gross");
            Console.WriteLine("10. Gross - Dussin");

            int userInput = Convert.ToInt32(Console.ReadLine());


            switch (userInput)
            {
                case 1:
                    OldSwedishQuantity.PiecesToDussin();
                    break;
                case 2:
                    OldSwedishQuantity.DussinToPieces();
                    break;
                case 3:
                    OldSwedishQuantity.PiecesToDussin();
                    break;
                case 4:
                    OldSwedishQuantity.DussinToPieces();
                    break;
                case 5:
                    OldSwedishQuantity.PiecesToTjog();
                    break;
                case 6:
                    OldSwedishQuantity.TjogToPieces();
                    break;
                case 7:
                    OldSwedishQuantity.PiecesToSkock();
                    break;
                case 8:
                    OldSwedishQuantity.SkockToPieces();
                    break;
                case 9:
                    OldSwedishQuantity.DussinToGross();
                    break;
                case 10:
                    OldSwedishQuantity.GrossToDussin();
                    break;
                default:
                    break;
            }
        }
    }
}