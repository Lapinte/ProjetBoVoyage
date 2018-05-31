using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.Stockage_Données
{
    class RecupererDestinationDepuisFichier
    {
        public static List<Destination> RecupererDestination(string nomDeFichier)
        {
            var listeDestination = new List<Destination>();

            if (File.Exists(nomDeFichier))
            {
                var lignes = File.ReadAllLines(nomDeFichier);

                foreach (var ligne in lignes)
                {
                    string[] champs = ligne.Split(';');
                    var destination = new Destination
                    {
                        Continent = champs[0],
                        Pays = champs[1],
                        Région = champs[2],
                        DescriptionVoyage = champs[3],
                    };

                    listeDestination.Add(destination);
                }
            }
            return listeDestination;
        }
    }
}
