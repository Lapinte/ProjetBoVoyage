using Projet_UML_CSharp.Classes_Métiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.UI
{
    class AfficherListeVoyages
    {
        public static void AfficherVoyage(List<Voyage> liste, bool afficherIndex)
        {
            if (liste.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Aucun voyage pour le moment");
                return;
            }
            var lignesBuilder = new StringBuilder();

            // Construction de la ligne d'en-tête
            if (afficherIndex)
            {
                lignesBuilder.AppendFormat("{0,-5} ", "NUM");
            }
            lignesBuilder.AppendFormat("{0,-20} {1,-15} {2,-15} {3,-75}", "DESTINATION", "DATE ALLER", "DATE RETOUR", "VOYAGEURS MAX");
            lignesBuilder.AppendLine();

            for (int i = 0; i < liste.Count; i++)
            {
                var voyage = liste[i];

                if (afficherIndex)
                {
                    lignesBuilder.AppendFormat($"{i,-5} ");
                }
                lignesBuilder.Append($"{voyage.Destination.Région,-20} {voyage.DateAller.ToShortDateString(),-15} {voyage.DateRetour.ToShortDateString(),-15} {voyage.NombreVoyageurMax,-75} ");
                lignesBuilder.AppendLine();
            }

            Console.Write(lignesBuilder.ToString());
        }
    }
}
