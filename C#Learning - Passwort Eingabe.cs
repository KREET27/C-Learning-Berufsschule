using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace Ein_und_Ausgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* decimal c;
             char d;
             bool e = true;

            Activity workflow1 = new Workflow1();
            WorkflowInvoker.Invoke(workflow1);
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Der Integer-Wert: {0}\t \t\t\t Hex-Wert: {0:E}\nDer Integer-Wert: {1} \t\t\t Hex-Wert: {1:E} \n Das Produkt der ist ", 255, 12345 );*/
            int versuche = 0;
            char x, y, z, w;
            Console.WriteLine("Gib das Passwort ein");

            x = Convert.ToChar(Console.ReadLine());
            y = Convert.ToChar(Console.ReadLine());
            z = Convert.ToChar(Console.ReadLine());
            w = Convert.ToChar(Console.ReadLine());

            int summe = x + y + z + w;
            Console.WriteLine("Wert: " + summe);



            if (summe == 313 || summe == 345 || summe == 377 || summe == 489 || summe == 441 || summe == 409) 

            {
                Console.WriteLine("LOGIN korrekt");
                
            }
            else
            {
                Console.WriteLine("Falsches Passwort.");
                versuche++;
            }
             
            if (versuche == 3)
                {
                Console.WriteLine("Login fehlgeschlagen.");
                    }

            Console.WriteLine("Anzahl Versuche: " + versuche);




}
}
}

