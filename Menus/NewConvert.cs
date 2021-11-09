using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverteraren.Menus
{
    class NewConvert
    {

        public static void ConvertAgain()
        {
            Console.WriteLine("Vill du göra en ny konvertering? ");
            Console.WriteLine("1. Ja ");
            Console.WriteLine("2. Nej ");



            int userInput = Convert.ToInt32(Console.ReadLine());



            switch (userInput)
            {
                case 1:
                    Lines.Line();
                    HeadMenu.Menu();
                    break;
                case 2:
                    Lines.Line();
                    Console.WriteLine("Tack för denna gång!");
                    break;
            }

        }

    }
}
