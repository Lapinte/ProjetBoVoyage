using Projet_UML_CSharp.Affichage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.UI
{
    class MenuBaseDeDonnéeClient
    {
        public static void VoirBaseDeDonnéeClient()
        {
            AfficherEnTete.MethodeAfficherEnTete("GESTION DES CLIENTS");

            Console.WriteLine("1. Lister les clients");
            Console.WriteLine("2. Envoyer un email à un client");
            Console.WriteLine("3. Supprimer un client");
            Console.WriteLine("R. Retour");
            Console.WriteLine();
            Console.Write("Votre choix: ");
        }
    }
}
