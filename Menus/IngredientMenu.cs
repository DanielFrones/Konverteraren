using Konverteraren.Converters;
using System;

namespace Konverteraren.Menus
{
    internal class IngridientMenu
    {


        public static void Menu()
        {

            Console.WriteLine("Välj Kategori : ");
            Console.WriteLine("1. Mjöl ");
            Console.WriteLine("2. Socker ");
            Console.WriteLine("3. Matfett ");

            int choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("1. Deciliter - Bovetemjöl");
                    Console.WriteLine("2. Bovetemjöl - Deciliter");
                    Console.WriteLine("3. Deciliter - Gramhamsmjöl");
                    Console.WriteLine("4. Gramhamsmjöl - Deciliter");
                    Console.WriteLine("5. Deciliter - Vetemjöl");
                    Console.WriteLine("6. Vetemjöl - Deciliter");
                    Console.WriteLine("7. Deciliter - Rågmjöl");
                    Console.WriteLine("8. Rågmjöl - Deciliter");
                    Console.WriteLine("9. Deciliter - Rågsikt");
                    Console.WriteLine("10. Rågsikt - Deciliter");

                    int userInputWheat = Convert.ToInt32(Console.ReadLine());

                    switch (userInputWheat)
                    {
                        case 1:
                            Ingridients.DeciliterToWheat(Ingridients.NumberOfDeciliters());
                            break;
                        case 2:
                            Ingridients.WheatToDeciliter(Ingridients.NumberOfGrams());
                            break;
                        case 3:
                            Ingridients.DeciliterToWheat(Ingridients.NumberOfDeciliters());
                            break;
                        case 4:
                            Ingridients.WheatToDeciliter(Ingridients.NumberOfGrams());
                            break;
                        case 5:
                            Ingridients.DeciliterToWheat(Ingridients.NumberOfDeciliters());
                            break;
                        case 6:
                            Ingridients.WheatToDeciliter(Ingridients.NumberOfGrams());
                            break;
                        case 7:
                            Ingridients.DeciliterToRyeWheat(Ingridients.NumberOfDeciliters());
                            break;
                        case 8:
                            Ingridients.RyeWheatToDeciliter(Ingridients.NumberOfGrams());
                            break;
                        case 9:
                            Ingridients.DeciliterToRyeWheat(Ingridients.NumberOfDeciliters());
                            break;
                        case 10:
                            Ingridients.RyeWheatToDeciliter(Ingridients.NumberOfGrams());
                            break;
                    }
                    break;
                case 2:

                    Console.WriteLine("1. Deciliter - Sirap");
                    Console.WriteLine("2. Sirap - Deciliter");
                    Console.WriteLine("3. Deciliter - Honung");
                    Console.WriteLine("4. Honung - Deciliter");
                    Console.WriteLine("5. Deciliter - Strösocker");
                    Console.WriteLine("6. Strösocker - Deciliter");
                    Console.WriteLine("7. Deciliter - Farinsocker");
                    Console.WriteLine("8. Farinsocker - Deciliter");
                    Console.WriteLine("9. Deciliter - Florsocker");
                    Console.WriteLine("10. Florsocker - Deciliter");

                    int userInputSugar = Convert.ToInt32(Console.ReadLine());

                    switch (userInputSugar)
                    {
                        case 1:
                            Ingridients.DeciliterToSyrypAndHoney(Ingridients.NumberOfDeciliters());
                            break;
                        case 2:
                            Ingridients.SyrypAndHoneyToDeciliter(Ingridients.NumberOfGrams());
                            break;
                        case 3:
                            Ingridients.DeciliterToSyrypAndHoney(Ingridients.NumberOfDeciliters());
                            break;
                        case 4:
                            Ingridients.SyrypAndHoneyToDeciliter(Ingridients.NumberOfGrams());
                            break;
                        case 5:
                            Ingridients.DeciliterToStroSugar(Ingridients.NumberOfDeciliters());
                            break;
                        case 6:
                            Ingridients.StroSugarToDeciliter(Ingridients.NumberOfGrams());
                            break;
                        case 7:
                            Ingridients.DeciliterToFarinSugar(Ingridients.NumberOfDeciliters());
                            break;
                        case 8:
                            Ingridients.FarinSugarToDeciliter(Ingridients.NumberOfGrams());
                            break;
                        case 9:
                            Ingridients.DeciliterToFlorSugar(Ingridients.NumberOfDeciliters());
                            break;
                        case 10:
                            Ingridients.FlorSugarToDeciliter(Ingridients.NumberOfGrams());
                            break;
                        default:
                            break;
                    }

                    break;

                case 3:

                    Console.WriteLine("1. Deciliter - Fast Smör");
                    Console.WriteLine("2. Fast Smör - Deciliter");
                    Console.WriteLine("3. Deciliter - Kokosfett");
                    Console.WriteLine("4. Kokosfett - Deciliter");
                    Console.WriteLine("5. Deciliter - Smält Smör");
                    Console.WriteLine("6. Smält Smör - Deciliter");
                    Console.WriteLine("7. Deciliter - Olja");
                    Console.WriteLine("8. Olja - Deciliter");
                    Console.WriteLine("9. Deciliter - Ister");
                    Console.WriteLine("10. Ister - Deciliter");

                    int userInputButter = Convert.ToInt32(Console.ReadLine());

                    switch (userInputButter)
                    {
                        case 1:
                            Ingridients.DeciliterToHardButter(Ingridients.NumberOfDeciliters());
                            break;
                        case 2:
                            Ingridients.HardButterToDeciliter(Ingridients.NumberOfGrams());
                            break;
                        case 3:
                            Ingridients.DeciliterToCooconutFat(Ingridients.NumberOfDeciliters());
                            break;
                        case 4:
                            Ingridients.CoconutFatToDeciliter(Ingridients.NumberOfGrams());
                            break;
                        case 5:
                            Ingridients.DeciliterToMeltedButter(Ingridients.NumberOfDeciliters());
                            break;
                        case 6:
                            Ingridients.MeltedButterToDeciliter(Ingridients.NumberOfGrams());
                            break;
                        case 7:
                            Ingridients.DeciliterToOil(Ingridients.NumberOfDeciliters());
                            break;
                        case 8:
                            Ingridients.OilToDeciliter(Ingridients.NumberOfGrams());
                            break;
                        case 9:
                            Ingridients.DeciliterToIster(Ingridients.NumberOfDeciliters());
                            break;
                        case 10:
                            Ingridients.IsterToDeciliter(Ingridients.NumberOfGrams());
                            break;
                        default:
                            break;
                    }

                    break;

            }




        }


    }
}