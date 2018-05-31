using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_UML_CSharp.Classes_Métiers;

namespace Projet_UML_CSharp.Stockage_Données
{
    class RecupererVoyageDepuisFichier
    {
        public static List<Voyage> RecupererVoyage(string nomDeFichier)
        {
            var listeVoyage = new List<Voyage>();

            if (File.Exists(nomDeFichier))
            {
                var lignes = File.ReadAllLines(nomDeFichier);

                foreach (var ligne in lignes)
                {
                    string[] champs = ligne.Split(';');
                    var nomDestination = champs[0];
                    var destination = Données.Destinations.Where(x => x.Région == nomDestination).FirstOrDefault();
                    var voyage = new Voyage
                    {
                        Destination = destination,
                        DateAller = DateTime.Parse(champs[1]),
                        DateRetour = DateTime.Parse(champs[2]),
                        NombreVoyageurMax = int.Parse(champs[3]),
                    };

                    listeVoyage.Add(voyage);
                }
            }
            return listeVoyage;
        }

    }
}
