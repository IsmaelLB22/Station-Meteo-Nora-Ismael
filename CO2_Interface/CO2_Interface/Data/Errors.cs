using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/************* CODE EXAMEN: DEBUT *************/

namespace CO2_Interface.Data
{
    internal class Errors
    {

        internal byte Ref;
        internal byte Type; // 1 / 2 / 3 / 4 / 5 Erreur:  Connexion / trame / fichier csv / bdd / fonctionnement interface  
        internal string Date;
        internal string Description;
        private static byte idCounter = 0;

        internal Errors(byte type , string descritption)
        {
            Ref = idCounter++;
            Type = type;
            Date = DateTime.Now.ToString();
            Description = descritption;
        }

    }
}

/************* CODE EXAMEN: FIN **************/
