using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Mad ret1 = new Mad(1, "Kyllingebryst", 120, false);
            Mad ret2 = new Mad(2, "Kamsteg", 80, false);
            Drik d1 = new Drik();
            Drik d2 = new Drik("Øl", 45.5, 33);
            d1.Navn = "Cola";
            d1.Size = 44.5;


            Kunde k1 = new Kunde("Poul", "2323233");

            Ordre o1 = new Ordre(10);

            o1.Kunde = k1; 

            o1.AddMadTilOrdre(ret2);
            o1.AddMadTilOrdre(ret2);
            o1.AddDrikTilOrdre(d1);


           

            Console.WriteLine(d1.Navn);
            d1.GivInfo();
            d2.GivInfo();


            Ordre newO = new Ordre(2);
            newO.AddMadTilOrdre(ret1);
            newO.AddDrikTilOrdre(d2);

            // The LAST line of code should be ABOVE this line
        }
    }
}