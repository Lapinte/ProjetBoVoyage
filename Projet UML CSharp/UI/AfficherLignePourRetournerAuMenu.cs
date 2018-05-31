using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.UI
{
    class AfficherLignePourRetournerAuMenu
    {
        public static void LignePourRetournerAuMenu()
        {
            Console.WriteLine();
            Console.Write("> Appuyez pour retourner au menu...");
            Console.ReadKey();
        }
    }
}
