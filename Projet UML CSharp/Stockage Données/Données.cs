using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.Stockage_Données
{
    public static class Données
    {
        private static List<Destination> destinations;

        public static List<Destination> Destinations
        {
            get
            {
                if (destinations==null)
                {
                    destinations = RecupererDestinationDepuisFichier.RecupererDestination("Destination.txt");
                }

                return destinations;
            }


        }
    }
}
