using Konverteraren.Menus;
using System;

namespace Konverteraren.Converters
{
    public class Brittish
    {

        public static double GallonToLiter()
        {
            Console.WriteLine("Hur många gallon vill du konvertera?");
            double gallon = Convert.ToDouble(Console.ReadLine());
            double liter = Math.Round(gallon * 4.5, 2);
            Console.WriteLine("{0} gallon = {1} liter", gallon, liter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return liter;
        }


        public static double LiterToGallon()
        {
            Console.WriteLine("Hur många liter vill du konvertera?");
            double liter = Convert.ToDouble(Console.ReadLine());
            double gallon = Math.Round(liter / 4.5, 2);
            Console.WriteLine("{0} gallon = {1} liter", liter, gallon);
            Lines.Line();
            NewConvert.ConvertAgain();
            return gallon;
        }


        public static double PintToDeciliter()
        {
            Console.WriteLine("Hur många pint vill du konvertera?");
            double pint = Convert.ToDouble(Console.ReadLine());
            double deciliter = Math.Round(pint * 5.7, 2);
            Console.WriteLine("{0} pint = {1} deciliter", pint, deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }


        public static double DeciliterToPint()
        {
            Console.WriteLine("Hur många deciliter vill du konvertera?");
            double deciliter = Convert.ToDouble(Console.ReadLine());
            double pint = Math.Round(deciliter / 5.7, 2);
            Console.WriteLine("{0} deciliter = {1} pint", deciliter, pint);
            Lines.Line();
            NewConvert.ConvertAgain();
            return pint;
        }


        public static double CupToDeciliter()
        {
            Console.WriteLine("Hur många cup vill du konvertera?");
            double cup = Convert.ToDouble(Console.ReadLine());
            double deciliter = Math.Round(cup * 2.8, 2);
            Console.WriteLine("{0} cup = {1} deciliter", cup, deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }


        public static double DeciliterToCup()
        {
            Console.WriteLine("Hur många deciliter vill du konvertera?");
            double deciliter = Convert.ToDouble(Console.ReadLine());
            double cup = Math.Round(deciliter / 2.8, 2);
            Console.WriteLine("{0} deciliter = {1} cup", deciliter, cup);
            Lines.Line();
            NewConvert.ConvertAgain();
            return cup;
        }


        public static double OunceToMilliliter()
        {
            Console.WriteLine("Hur många UK fluid ounce vill du konvertera?");
            double ounce = Convert.ToDouble(Console.ReadLine());
            double milliliter = Math.Round(ounce * 28, 2);
            Console.WriteLine("{0} UK fluid ounce = {1} milliliter", ounce, milliliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return milliliter;
        }


        public static double MilliliterToOunce()
        {
            Console.WriteLine("Hur många milliliter vill du konvertera?");
            double milliliter = Convert.ToDouble(Console.ReadLine());
            double ounce = Math.Round(milliliter / 28, 2);
            Console.WriteLine("{0} milliliter = {1} UK fluid ounce", milliliter, ounce);
            Lines.Line();
            NewConvert.ConvertAgain();
            return ounce;
        }


        public static double TablespoonToMilliliter()
        {
            Console.WriteLine("Hur många tablespoons vill du konvertera?");
            double tablespoon = Convert.ToDouble(Console.ReadLine());
            double milliliter = Math.Round(tablespoon * 15, 2);
            Console.WriteLine("{0} tablespoon = {1} milliliter", tablespoon, milliliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return milliliter;
        }


        public static double MilliliterToTablespoon()
        {
            Console.WriteLine("Hur många milliliter vill du konvertera?");
            double milliliter = Convert.ToDouble(Console.ReadLine());
            double tablespoon = Math.Round(milliliter / 15, 2);
            Console.WriteLine("{0} milliliter = {1} tablespoon", milliliter, tablespoon);
            Lines.Line();
            NewConvert.ConvertAgain();
            return tablespoon;
        }


        public static double TeaspoonToMilliliter()
        {
            Console.WriteLine("Hur många teaspoons vill du konvertera?");
            double teaspoon = Convert.ToDouble(Console.ReadLine());
            double milliliter = Math.Round(teaspoon * 5, 2);
            Console.WriteLine("{0} teaspoon = {1} milliliter", teaspoon, milliliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return milliliter;
        }


        public static double MilliliterToTeaspoon()
        {
            Console.WriteLine("Hur många milliliter vill du konvertera?");
            double milliliter = Convert.ToDouble(Console.ReadLine());
            double teaspoon = Math.Round(milliliter / 5, 2);
            Console.WriteLine("{0} teaspoon = {1} milliliter", teaspoon, milliliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return teaspoon;
        }


        public static double PoundToKilo()
        {
            Console.WriteLine("Hur många pound vill du konvertera?");
            double pound = Convert.ToDouble(Console.ReadLine());
            double kilo = Math.Round(pound * 0.45, 2);
            Console.WriteLine("{0} pound = {1} kilo", pound, kilo);
            Lines.Line();
            NewConvert.ConvertAgain();
            return kilo;
        }


        public static double KiloToPound()
        {
            Console.WriteLine("Hur många kilo vill du konvertera?");
            double kilo = Convert.ToDouble(Console.ReadLine());
            double pound = Math.Round(kilo / 0.45, 2);
            Console.WriteLine("{0} kilo = {1} pound", kilo, pound);
            Lines.Line();
            NewConvert.ConvertAgain();
            return pound;
        }


    }
}