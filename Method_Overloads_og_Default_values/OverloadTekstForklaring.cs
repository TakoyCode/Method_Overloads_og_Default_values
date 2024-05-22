using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Method_Overloads_og_Default_values
{
   
    // Det finnes noe i programmering som heter å "overloade" en metode.
    // D.v.s man lager flere kopier av samme metode dersom man vil ha muligheten til å ta i mot et ulikt antall parametere inn.
    // Man kan overloade alle metoder, inklusiv en constructor.

    // Eksempel:
    class OverloadExample
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }
    // Her bruker vi den samme metoden Add, men med forskjellige eller fler parametre.
    // Man kan dermed kjøre Add()-metoden og sende med forskjellige values.
    
    // Eksempel:
    internal class OverloadTekstForklaring
    {
        public void Example2()
        {
        OverloadExample calculator = new OverloadExample();
        Console.WriteLine("Sum med to int-parametre: " + calculator.Add(5,10));
        Console.WriteLine("Sum med 3 int-parametre: " + calculator.Add(5,10,2));
        Console.WriteLine("Sum med to double-parametre: " + calculator.Add(5.2,4.6));
        }
    }
}

