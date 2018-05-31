using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.Affichage
{
    public static class CentrerLeTexte
    {
        public static void Centrer(string texte)

        {

            int nbEspaces = (Console.WindowWidth - texte.Length) / 2;

            Console.SetCursorPosition(nbEspaces, Console.CursorTop);

            Console.WriteLine(texte);

        }
    }
}
