using Konverteraren.Menus;
using System;

namespace Konverteraren.Converters
{
    internal class Ingridients
    {



        public static double NumberOfDeciliters()
        {

            Console.Write("Antal deciliter att konvertera : ");
            double deciliter = Convert.ToDouble(Console.ReadLine());
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;

        }

        public static double NumberOfGrams()
        {
            Console.Write("Antal gram att konvertera : ");
            double grams = Convert.ToDouble(Console.ReadLine());
            Lines.Line();
            NewConvert.ConvertAgain();
            return grams;
        }

        public static double DeciliterToWheat(double deciliter)
        {

            double grams = Math.Round(deciliter * 60, 2);
            Console.WriteLine("{0} Deciliter = {1} Gram", deciliter, grams);
            Lines.Line();
            NewConvert.ConvertAgain();
            return grams;
        }

        public static double WheatToDeciliter(double grams)
        {
            double deciliter = Math.Round(grams / 60, 2);
            Console.WriteLine("{0} Gram = {1} Deciliter", grams, deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }

        public static double DeciliterToRyeWheat(double deciliter)
        {
            double grams = Math.Round(deciliter * 55, 2);
            Console.WriteLine("{0} Deciliter = {1} Gram", deciliter, grams);
            Lines.Line();
            NewConvert.ConvertAgain();
            return grams;
        }

        public static double RyeWheatToDeciliter(double grams)
        {
            double deciliter = Math.Round(grams / 55, 2);
            Console.WriteLine("{0} Gram = {1} Deciliter", grams, deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }

        public static double DeciliterToSyrypAndHoney(double deciliter)
        {
            double grams = Math.Round(deciliter * 60, 2);
            Console.WriteLine("{0} Deciliter = {1} Gram", deciliter, grams);
            Lines.Line();
            NewConvert.ConvertAgain();
            return grams;
        }

        public static double SyrypAndHoneyToDeciliter(double grams)
        {
            double deciliter = Math.Round(grams / 60, 2);
            Console.WriteLine("{0} Gram = {1} Deciliter", grams, deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }

        public static double DeciliterToStroSugar(double deciliter)
        {
            double grams = Math.Round(deciliter * 90, 2);
            Console.WriteLine("{0} Deciliter = {1} Gram", deciliter, grams);
            Lines.Line();
            NewConvert.ConvertAgain();
            return grams;
        }

        public static double StroSugarToDeciliter(double grams)
        {
            double deciliter = Math.Round(grams / 90, 2);
            Console.WriteLine("{0} Gram = {1} Deciliter", grams, deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }

        public static double DeciliterToFarinSugar(double deciliter)
        {
            double grams = Math.Round(deciliter * 60, 2);
            Console.WriteLine("{0} Deciliter = {1} Gram", deciliter, grams);
            Lines.Line();
            NewConvert.ConvertAgain();
            return grams;
        }

        public static double FarinSugarToDeciliter(double grams)
        {
            double deciliter = Math.Round(grams / 60, 2);
            Console.WriteLine("{0} Gram = {1} Deciliter", grams, deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }

        public static double DeciliterToFlorSugar(double deciliter)
        {
            double grams = Math.Round(deciliter * 60, 2);
            Console.WriteLine("{0} Deciliter = {1} Gram", deciliter, grams);
            Lines.Line();
            NewConvert.ConvertAgain();
            return grams;
        }

        public static double FlorSugarToDeciliter(double grams)
        {
            double deciliter = Math.Round(grams / 60, 2);
            Console.WriteLine("{0} Gram = {1} Deciliter", grams, deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }

        public static double DeciliterToHardButter(double deciliter)
        {
            double grams = Math.Round(deciliter * 95, 2);
            Console.WriteLine("{0} Deciliter = {1} Gram", deciliter, grams);
            Lines.Line();
            NewConvert.ConvertAgain();
            return grams;
        }

        public static double HardButterToDeciliter(double grams)
        {
            double deciliter = Math.Round(grams / 95, 2);
            Console.WriteLine("{0} Gram = {1} Deciliter", grams, deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }

        public static double DeciliterToCooconutFat(double deciliter)
        {
            double grams = Math.Round(deciliter * 95, 2);
            Console.WriteLine("{0} Deciliter = {1} Gram", deciliter, grams);
            Lines.Line();
            NewConvert.ConvertAgain();
            return grams;
        }

        public static double CoconutFatToDeciliter(double grams)
        {
            double deciliter = Math.Round(grams / 95, 2);
            Console.WriteLine("{0} Gram = {1} Deciliter", grams, deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }

        public static double DeciliterToMeltedButter(double deciliter)
        {
            double grams = Math.Round(deciliter * 90, 2);
            Console.WriteLine("{0} Deciliter = {1} Gram", deciliter, grams);
            Lines.Line();
            NewConvert.ConvertAgain();
            return grams;
        }

        public static double MeltedButterToDeciliter(double grams)
        {
            double deciliter = Math.Round(grams / 90, 2);
            Console.WriteLine("{0} Gram = {1} Deciliter", grams, deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }

        public static double DeciliterToOil(double deciliter)
        {
            double grams = Math.Round(deciliter * 90, 2);
            Console.WriteLine("{0} Deciliter = {1} Gram", deciliter, grams);
            Lines.Line();
            NewConvert.ConvertAgain();
            return grams;
        }

        public static double OilToDeciliter(double grams)
        {
            double deciliter = Math.Round(grams / 90, 2);
            Console.WriteLine("{0} Gram = {1} Deciliter", grams, deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }

        public static double DeciliterToIster(double deciliter)
        {
            double grams = Math.Round(deciliter * 85, 2);
            Console.WriteLine("{0} Deciliter = {1} Gram", deciliter, grams);
            Lines.Line();
            NewConvert.ConvertAgain();
            return grams;
        }

        public static double IsterToDeciliter(double grams)
        {
            double deciliter = Math.Round(grams / 85, 2);
            Console.WriteLine("{0} Gram = {1} Deciliter", grams, deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }

    }

}
