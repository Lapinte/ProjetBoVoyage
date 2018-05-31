using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_UML_CSharp.Affichage;

namespace Projet_UML_CSharp.UI
{
    class MenuIntranet
    {
        public static void VoirIntranet()
        {
            AfficherEnTete.MethodeAfficherEnTete("INTRANET");

            Console.WriteLine("1. Gestion des voyages");
            Console.WriteLine("2. Gestion des clients");
            Console.WriteLine("Q. Quitter");
            Console.WriteLine();
            Console.Write("Votre choix: ");
        }
    }
}
