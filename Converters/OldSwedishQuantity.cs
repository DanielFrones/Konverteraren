using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverteraren.Menus
{
    internal class OldSwedishQuantity
    {
        public static double DussinToGross()
        {
            Console.WriteLine("Hur många dussin? ");
            double dussin = Convert.ToDouble(Console.ReadLine());
            double gross = Math.Round(dussin / 12, 2);
            Console.WriteLine("= {0}", gross);
            Lines.Line();
            NewConvert.ConvertAgain();
            return gross;
        }
        public static double GrossToDussin()
        {
            Console.WriteLine("Hur många gross? ");
            double gross = Convert.ToDouble(Console.ReadLine());
            double dussin = Math.Round(gross * 12, 2);
            Console.WriteLine("= {0}", dussin);
            Lines.Line();
            NewConvert.ConvertAgain();
            return dussin;
        }
        public static double PiecesToSkock()
        {
            Console.WriteLine("Hur många pieces? ");
            double styck = Convert.ToDouble(Console.ReadLine());
            double skock = Math.Round(styck / 60, 2);
            Console.WriteLine("= {0}", skock);
            Lines.Line();
            NewConvert.ConvertAgain();
            return skock;
        }
        public static double SkockToPieces()
        {
            Console.WriteLine("Hur många skock? ");
            double skock = Convert.ToDouble(Console.ReadLine());
            double styck = Math.Round(skock * 60, 2);
            Console.WriteLine("= {0}", styck);
            Lines.Line();
            NewConvert.ConvertAgain();
            return styck;
        }
        public static double PiecesToTjog()
        {
            Console.WriteLine("Hur många pieces? ");
            double pieces = Convert.ToDouble(Console.ReadLine());
            double tjog = Math.Round(pieces / 20, 2);
            Console.WriteLine("= {0}", tjog);
            Lines.Line();
            NewConvert.ConvertAgain();
            return tjog;
        }
        public static double TjogToPieces()
        {
            Console.WriteLine("Hur många tjog? ");
            double tjog = Convert.ToDouble(Console.ReadLine());
            double pieces = Math.Round(tjog * 20, 2);
            Console.WriteLine("= {0}", pieces);
            Lines.Line();
            NewConvert.ConvertAgain();
            return pieces;
        }
        public static double PiecesToDussin()
        {
            Console.WriteLine("Hur många pieces? ");
            double pieces = Convert.ToDouble(Console.ReadLine());
            double dussin = Math.Round(pieces / 12, 2);
            Console.WriteLine("= {0}", dussin);
            Lines.Line();
            NewConvert.ConvertAgain();
            return dussin;
        }
        public static double DussinToPieces()
        {
            Console.WriteLine("Hur många dussin? ");
            double dussin = Convert.ToDouble(Console.ReadLine());
            double pieces = Math.Round(dussin * 12, 2);
            Console.WriteLine("= {0}", pieces);
            Lines.Line();
            NewConvert.ConvertAgain();
            return pieces;
        }

    }
}