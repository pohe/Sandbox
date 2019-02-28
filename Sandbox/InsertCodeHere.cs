using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Mad ret1 = new Mad(1, "Kyllingebryst", 120,false);
            Mad ret2 = new Mad(2, "Kamsteg", 80, false);



            Ordre o1 = new Ordre(10);
            o1.AddMadTilOrdre(ret2);
            o1.Mad = ret2; 
            o1.ordreBeskrivelse("Din bestilling er: ");

            // The LAST line of code should be ABOVE this line
        }
    }
}