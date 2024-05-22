using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloads_og_Default_values
{
    internal class Oppave
    {
        public void Run()
        {
            PrintWelcomeMessage();
            PrintWelcomeMessage("Audun");
        }

        private void PrintWelcomeMessage(string name = "Du er snill!")
        {
            Console.WriteLine("Hei og velkommen " + name);
        }
        //private void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Hei og velkommen");
        //}
    }
}
