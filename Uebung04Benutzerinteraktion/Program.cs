
/*
 *            Schreiben Sie ein Programm, das einen Benutzer befragt, 
 *            ob er fortfahren will und seine Antwort "(j)a oder (n)ein"
 *            als Booleschen Wert ausgibt. Um falschen Eingaben (z.B. 'y')
 *            vorzubeugen, soll dem Benutzer ein dreimalige Wiederholung
 *            ermöglicht werden
 *
 */

using System;

namespace Uebung04Benutzerinteraktion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nUebung04 Benutzerinteraktion");
            Console.WriteLine("----------------------------");

            bool programmBeenden = false;
            short anzahlVersuche = 0;
            short maxVersuche = 3;
            string benutzereingabe = "";

            while(!programmBeenden)
            {
                Console.WriteLine("Soll das Programm beendent werden? [(j)a oder (n)ein]");

                benutzereingabe = Console.ReadLine();
                
                if(benutzereingabe == "j")
                {
                    Console.WriteLine("Okay, das Programm wird beendet");
                    programmBeenden = true;
                }
                else if (benutzereingabe == "n")
                {
                    Console.WriteLine("Okay, dann halt noch ne Runde :)");
                    anzahlVersuche = 0;
                }
                else
                {
                    anzahlVersuche++;
                    Console.WriteLine("Das Zeichen kenn ich nicht, benutz 'j' oder 'n' du Trottel");
                    Console.WriteLine("Du hast noch {0} Versuche bevor ich das Programm selbst beende..." , maxVersuche - anzahlVersuche);
                }

                if(anzahlVersuche >= maxVersuche)
                {
                    Console.WriteLine("\n" +
                        "Ok ok ich seh schon, ich machs selber, bis dann du Trottel ...");
                    programmBeenden = true;
                }
            }

            Console.ReadKey();
        }
    }
}
