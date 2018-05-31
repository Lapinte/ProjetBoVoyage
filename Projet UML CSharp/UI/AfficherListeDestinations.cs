using Projet_UML_CSharp.Stockage_Données;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.UI
{
    class AfficherListeDestinations
    {
        public static void AfficherDestination(List<Destination> liste, bool afficherIndex)
        {
            if (liste.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Aucune destination pour le moment");
                return;
            }
            var lignesBuilder = new StringBuilder();

            // Construction de la ligne d'en-tête
            if (afficherIndex)
            {
                lignesBuilder.AppendFormat("{0,-5} ", "NUM");
            }
            lignesBuilder.AppendFormat("{0,-20} {1,-15} {2,-15} {3,-75}", "CONTINENT", "PAYS", "REGION", "DESCRIPTION");
            lignesBuilder.AppendLine();

            for (int i = 0; i < liste.Count; i++)
            {
                var destination = liste[i];

                if (afficherIndex)
                {
                    lignesBuilder.AppendFormat($"{i,-5} ");
                }
                lignesBuilder.Append($"{destination.Continent,-20} {destination.Pays,-15} {destination.Région,-15} {destination.DescriptionVoyage,-75} ");
                lignesBuilder.AppendLine();
            }

            Console.Write(lignesBuilder.ToString());
        }
    }
}
