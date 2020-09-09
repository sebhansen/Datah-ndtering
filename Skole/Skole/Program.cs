using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole
{
    class Program
    {
        static void Main(string[] args)
        {

            //Beregn arealet af et rektangel
            /*
            Console.WriteLine("Beregn areal for en firkant");
            Console.WriteLine("Skriv højde:");

            double højde;
            double bredde;

            højde = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv bredde");
            bredde = double.Parse(Console.ReadLine());

            Console.WriteLine("Arealet af firkanten er " + (højde*bredde) + " cm2");
            Console.ReadKey();
            */

            //Beregn hældningen ud fra to punkter
            /*
            Console.WriteLine("Velkommen til dagens matematik lektion");
            Console.WriteLine("I dag skal vi finde hældningen på et linjestykke.");
            Console.WriteLine("");
            Console.WriteLine("Skriv punktet x1");
            double x1;
                x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv punktet y1");
            double y1;
                y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv punktet x2");
            double x2;
                x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv punktet y2");
            double y2;
                y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("h = " + ((y2 - y1) / (x2 - x1)));
            Console.ReadKey();
            */

            //Alternativ måde hvor man definerer h
            /*
            Console.WriteLine("Velkommen til dagens matematik lektion");
            Console.WriteLine("I dag skal vi finde hældningen på et linjestykke.");
            Console.WriteLine("");
            Console.WriteLine("Skriv punktet x1");
            int x1;
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv punktet y1");
            int y1;
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv punktet x2");
            int x2;
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv punktet y2");
            int y2;
            y2 = int.Parse(Console.ReadLine());
            double h;
                h = ((y2 - y1) / (x2 - x1));
            Console.WriteLine("h = " + h);
            Console.ReadLine();
            */

            //Beregn antallet af tegn i et tekst
            /*
            Console.WriteLine("Hvor mange tegn er der i din tekst? Lad os finde ud af det!");
            string yeet = Console.ReadLine();
            int length = yeet.Length;
            Console.WriteLine("Din tekst er på " + length + " tegn");
            Console.ReadKey();
            */

            //Substring med given tekst
            /*
            string yoink = "Jeg har en hest";

            string partWithoutLength = yoink.Substring(1);
            string partWithLength = yoink.Substring(11);
            Console.WriteLine(partWithoutLength);
            Console.WriteLine(partWithLength);
            Console.ReadKey();
            */

            //Substring med egen tekst i console
            /*
            Console.WriteLine("Skriv dit navn");
            string navn = Console.ReadLine();
            Console.WriteLine("Dit navn er " + navn);
            Console.WriteLine("Skriv ved hvilket tegn det nye navn skal starte");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv hvor den skal slutte");
            int tal2 = int.Parse(Console.ReadLine());
            string substring = navn.Substring(tal1, tal2);
            Console.WriteLine(substring);
            Console.ReadKey();
            */

            //Substring hvor den også tæller antal tegn
            /*
            Console.WriteLine("Skriv dit navn");
            string dig = Console.ReadLine();
            int lengths = dig.Length;
            Console.WriteLine("Din tekst er på " + lengths + " tegn");
            Console.WriteLine("Skriv et tal fra 1 til " + lengths);
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            string substring = dig.Substring(tal1, tal2);
            Console.WriteLine(substring);
            Console.ReadKey();
            */

            //Eksempel på brug af IndexOf
            /*
            Console.WriteLine("Skriv din sætning: ");
            string sætning = Console.ReadLine();
            int førsteBlank = sætning.IndexOf(' ');
            string udenFørste = sætning.Remove(0, førsteBlank + 1);
            int sidsteBlank = udenFørste.LastIndexOf(' ');
            string udenFørsteogSidste = udenFørste.Remove(sidsteBlank);
            Console.WriteLine("Nu fjerner vi det første og det sidste ord");
            Console.WriteLine(udenFørsteogSidste);
            Console.ReadKey();
            */
        }
    }
}
