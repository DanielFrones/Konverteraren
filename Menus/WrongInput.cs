using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverteraren.Menus
{
    public class WrongInput
    {
        public static void Wrong()
        {
            Console.WriteLine("Fel inmatning, tryck på valfri tangent för att göra rätt val.");
            Console.ReadKey();
            Lines.Line();
            
        }
    }

}
