using Projet_UML_CSharp.Affichage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.UI
{
    class MenuGestionClients
    {
        public static void VoirGestionClient()
        {
            AfficherEnTete.MethodeAfficherEnTete("GESTION CLIENT");

            Console.WriteLine("1. Base de donnée clients");
            Console.WriteLine("2. Gestion des dossiers de voyage");
            Console.WriteLine("R. Retour");
            Console.WriteLine();
            Console.Write("Votre choix: ");
        }
    }
}
