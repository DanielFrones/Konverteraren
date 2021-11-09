using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konverteraren.Converters;
using Konverteraren.Menus;

namespace Konverteraren.Converters
{
    public class American
    {
        public American()
        {



        }



        public static double GallonsToLiter()
        {
            Console.WriteLine("Hur många Gallons?");
            double gallons = Convert.ToDouble(Console.ReadLine());
            double liter = Math.Round(gallons * 3.8, 2);
            Console.WriteLine("= {0} liter", liter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return liter;
        }




        public static double LitersToGallon()
        {
            Console.WriteLine("Hur många Liter?");
            double liter = Convert.ToDouble(Console.ReadLine());
            double gallon = Math.Round(liter / 3.8, 2);
            Console.WriteLine("= {0} gallon", gallon);
            Lines.Line();
            NewConvert.ConvertAgain();
            return gallon;
        }




        public static double QuartToDeciliter()
        {
            Console.WriteLine("Hur många Quarts?");
            double quarts = Convert.ToDouble(Console.ReadLine());
            double deciliter = Math.Round(quarts * 9.5, 2);
            Console.WriteLine("= {0} deciliter", deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }




        public static double DeciliterToQuart()
        {
            Console.WriteLine("Hur många Liter?");
            double deciliter = Convert.ToDouble(Console.ReadLine());
            double quart = Math.Round(deciliter / 9.5, 2);
            Console.WriteLine("= {0} quart", quart);
            Lines.Line();
            NewConvert.ConvertAgain();
            return quart;
        }




        public static double PintToDeciliter()
        {
            Console.WriteLine("Hur många Pint?");
            double pint = Convert.ToDouble(Console.ReadLine());
            double deciliter = Math.Round(pint * 4.7, 2);
            Console.WriteLine("= {0} deciliter", deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }




        public static double DeciliterToPint()
        {
            Console.WriteLine("Hur många Deciliter?");
            double deciliter = Convert.ToDouble(Console.ReadLine());
            double pint = Math.Round(deciliter / 4.7, 2);
            Console.WriteLine("= {0} pint", pint);
            Lines.Line();
            NewConvert.ConvertAgain();
            return pint;
        }






        public static double CupToDeciliter()
        {
            Console.WriteLine("Hur många Cup?");
            double cup = Convert.ToDouble(Console.ReadLine());
            double deciliter = Math.Round(cup * 2.4, 2);
            Console.WriteLine("= {0} deciliter", deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;
        }




        public static double DeciliterToCup()
        {
            Console.WriteLine("Hur många Deciliter?");
            double deciliter = Convert.ToDouble(Console.ReadLine());
            double cup = Math.Round(deciliter / 2.4, 2);
            Console.WriteLine("= {0} cup", cup);
            Lines.Line();
            NewConvert.ConvertAgain();
            return cup;
        }





        public static double FluidOunceToMililiter()
        {
            Console.WriteLine("Hur många Fluid Ounce?");
            double fluidounce = Convert.ToDouble(Console.ReadLine());
            double mililiter = Math.Round(fluidounce * 30, 2);
            Console.WriteLine("= {0} mililiter", mililiter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return mililiter;
        }




        public static double MililiterToFluidOunce()
        {
            Console.WriteLine("Hur många Mililiter?");
            double mililiter = Convert.ToDouble(Console.ReadLine());
            double fluidounce = Math.Round(mililiter / 30, 2);
            Console.WriteLine("= {0} fluid ounce", fluidounce);
            Lines.Line();
            NewConvert.ConvertAgain();
            return fluidounce;
        }




        public static double OunceToGram()
        {
            Console.WriteLine("Hur många Ounce?");
            double ounce = Convert.ToDouble(Console.ReadLine());
            double gram = Math.Round(ounce * 28, 2);
            Console.WriteLine("= {0} gram", gram);
            Lines.Line();
            NewConvert.ConvertAgain();
            return gram;
        }




        public static double GramToOunce()
        {
            Console.WriteLine("Hur många Gram?");
            double gram = Convert.ToDouble(Console.ReadLine());
            double ounce = Math.Round(gram / 28, 2);
            Console.WriteLine("= {0} ounce", ounce);
            Lines.Line();
            NewConvert.ConvertAgain();
            return ounce;
        }



        public static double PoundToKilo()
        {
            Console.WriteLine("Hur många Pound?");
            double pound = Convert.ToDouble(Console.ReadLine());
            double kilo = Math.Round(pound * 0.45, 2);
            Console.WriteLine("= {0} kilo", kilo);
            Lines.Line();
            NewConvert.ConvertAgain();
            return kilo;
        }




        public static double KiloToPound()
        {
            Console.WriteLine("Hur många Kilo?");
            double kilo = Convert.ToDouble(Console.ReadLine());
            double pound = Math.Round(kilo / 0.45, 2);
            Console.WriteLine("= {0} pound", pound);
            Lines.Line();
            NewConvert.ConvertAgain();
            return pound;
        }



    }
}
