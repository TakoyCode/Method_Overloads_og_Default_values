using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloads_og_Default_values
{
    internal class DefaultValuesTekstForklaring
    {
        // Default verdi er verdien en ny variabel får hvis du ikke gir den en annen verdi.
        // Hvis man da ikke sender inn noe verdi inn som parameter, vil metoden fremdeles lese koden med default verdien.

        // Alle variabler har en default verdi. 
        // Int er 0, bool er false, string er null, osv.
        // Men du kan også definere din egen default verdi til et parameter

        // Eksempel:
       public void Example1()
        {
            int sum = LeggSammen(5,5);
            Console.WriteLine("Summen er: " + sum);
        }

        public int LeggSammen(int tall1 = 2, int tall2 = 3)
        {
            return tall1 + tall2;
        }

        // Her får LeggSammen-metoden sine parametere en default value på 2 og 3.
        // Hvis man kjører LeggSammen uten parametere, vil det da fremdeles returnere et tall (5 i dette tilfelle).
        // Hadde man skrevet int sum = LeggSammen(5,5); hadde metoden gitt 10 istedenfor.


    }
}
