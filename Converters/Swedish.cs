using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konverteraren.Menus;

namespace Konverteraren.Converters
{
    internal class Swedish
    {
        
        public static double LitersToMilliliter()
        {
            Console.WriteLine("Hur många liter?");
            double liter = Convert.ToDouble(Console.ReadLine());
            double milliliter = Math.Round(liter * 1000, 2);
            Console.WriteLine("= {0} milliliter", milliliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return milliliter;
            

        }

        public static double MilliliterToLiter()
        {
            Console.WriteLine("Hur många milliliter?");
            double milliliter = Convert.ToDouble(Console.ReadLine());
            double liter = Math.Round(milliliter / 1000, 2);
            Console.WriteLine("= {0} liter", liter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return liter;
        }


        public static double DeciliterToMilliliter()
        {
            Console.WriteLine("Hur många deciliter?");
            double deciliter = Convert.ToDouble(Console.ReadLine());
            double milliliter = Math.Round(deciliter * 100, 2);
            Console.WriteLine("= {0} millilter", milliliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return milliliter;

        }

        public static double MilliliterToDeciliter()
        {
            Console.WriteLine("Hur många deciliter?");
            double milliliter = Convert.ToDouble(Console.ReadLine());
            double deciliter = Math.Round(milliliter / 100, 2);
            Console.WriteLine("= {0} deciliter", deciliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return deciliter;

        }

        public static double CentiliterToMilliliter()
        {
            Console.WriteLine("Hur många centiliter?");
            double centiliter = Convert.ToDouble(Console.ReadLine());
            double milliliter = Math.Round(centiliter * 10, 2);
            Console.WriteLine("= {0} millilter", milliliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return milliliter;

        }
        public static double MilliliterToCentiliter()
        {
            Console.WriteLine("Hur många milliliter?");
            double milliliter = Convert.ToDouble(Console.ReadLine());
            double centiliter = Math.Round(milliliter / 10, 2);
            Console.WriteLine("= {0} centiliter", centiliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return centiliter;

        }

        public static double MatskedToMilliliter()
        {
            Console.WriteLine("Hur många matskedar?");
            double matskedar = Convert.ToDouble(Console.ReadLine());
            double milliliter = Math.Round(matskedar * 15, 2);
            Console.WriteLine("= {0} milliliter", milliliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return milliliter;

        }
        public static double MilliliterToMatsked()
        {
            Console.WriteLine("Hur många matskedar?");
            double milliliter = Convert.ToDouble(Console.ReadLine());
            double matskedar = Math.Round(milliliter / 15, 2);
            Console.WriteLine("= {0} matskedar", matskedar);
            Lines.Line();
            NewConvert.ConvertAgain();
            return matskedar;

        }

        public static double TeskedToMilliliter()
        {
            Console.WriteLine("Hur många teskedar?");
            double teskedar = Convert.ToDouble(Console.ReadLine());
            double milliliter = Math.Round(teskedar * 5, 2);
            Console.WriteLine("= {0} milliliter", milliliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return milliliter;

        }

        public static double MilliliterToTesked()
        {
            Console.WriteLine("Hur många teskedar?");
            double milliliter = Convert.ToDouble(Console.ReadLine());
            double teskedar = Math.Round(milliliter / 5, 2);
            Console.WriteLine("= {0} teskedar", teskedar);
            Lines.Line();
            NewConvert.ConvertAgain();
            return teskedar;

        }

        public static double KryddmåttToMilliliter()
        {
            Console.WriteLine("Hur många kryddmått?");
            double kryddmått = Convert.ToDouble(Console.ReadLine());
            double milliliter = Math.Round(kryddmått * 1, 2);
            Console.WriteLine("= {0} milliliter", milliliter);
            Lines.Line();
            NewConvert.ConvertAgain();
            return milliliter;

        }
        public static double MilliliterToKryddmått()
        {
            Console.WriteLine("Hur många milliter?");
            double milliliter = Convert.ToDouble(Console.ReadLine());
            double kryddmått = Math.Round(milliliter / 1, 2);
            Console.WriteLine("= {0} kryddmått", kryddmått);
            Lines.Line();
            NewConvert.ConvertAgain();
            return kryddmått;

        }
        public static double KiloToGram()
        {
            Console.WriteLine("Hur många kilo?");
            double kilo = Convert.ToDouble(Console.ReadLine());
            double gram = Math.Round(kilo * 1000, 2);
            Console.WriteLine("= {0} gram", gram);
            Lines.Line();
            NewConvert.ConvertAgain();
            return gram;

        }

        public static double GramToKilo()
        {
            Console.WriteLine("Hur många gram?");
            double gram = Convert.ToDouble(Console.ReadLine());
            double kilo = Math.Round(gram / 1000, 2);
            Console.WriteLine("= {0} kilo", kilo);
            Lines.Line();
            NewConvert.ConvertAgain();
            return kilo;

        }
        public static double HektoToGram()
        {
            Console.WriteLine("Hur många hekto?");
            double hekto = Convert.ToDouble(Console.ReadLine());
            double gram = Math.Round(hekto * 100, 2);
            Console.WriteLine("= {0} gram", gram);
            Lines.Line();
            NewConvert.ConvertAgain();
            return gram;

        }
        public static double GramToHekto()
        {
            Console.WriteLine("Hur många gram?");
            double gram = Convert.ToDouble(Console.ReadLine());
            double hekto = Math.Round(gram / 100, 2);
            Console.WriteLine("= {0} hekto", hekto);
            Lines.Line();
            NewConvert.ConvertAgain();
            return hekto;

        }
        public static double MilligramToGram()
        {
            Console.WriteLine("Hur många milligram?");
            double milligram = Convert.ToDouble(Console.ReadLine());
            double gram = Math.Round(milligram / 1000, 2);
            Console.WriteLine("= {0} gram", gram);
            Lines.Line();
            NewConvert.ConvertAgain();
            return gram;

        }

        public static double GramToMilligram()
        {
            Console.WriteLine("Hur många gram?");
            double gram = Convert.ToDouble(Console.ReadLine());
            double milligram = Math.Round(gram * 1000, 2);
            Console.WriteLine("= {0} milligram", milligram);
            Lines.Line();
            NewConvert.ConvertAgain();
            return milligram;

        }
    }
}
