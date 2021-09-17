using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Loops
    {
        ////////////////// Loop Opgave 1 (7)

        /* Hej dejlige gruppemedlemmer. Læs hvis du har brug for at forstå tankegangen.*/
        /* Jeg bruger for-loop til at løse denne opgave. I en for-loopen starter man med at lave et index nummer. Oftes starter man med at sætte index til at være 0, men jeg bruger 1 her da
         * det passer bedre med matematikken som skal udskrives. Index nummeret kaldes oftest i og er en integer.
         * Jeg sætter loop'en til at køre 10 gange. Men det skulle være 10*10. Derfor laver jeg endnu en loop inde i den første loop. Denne kører også 10 gange.
         * Det vil sige, at vi kører loop'en 10 gange, 10 gange. Altså 10 * 10. Jeg håber det giver mening!
         *      (Altså. Loop1's første runde kører loop2 10 gange. Loop1 anden runde kører også loop2 10 gange. Loop1 tredje runde
         *      kører også loop2 10 gange, osv. hele vejen til loop1 kommer 10 gange igennem!)
         * Jeg bruger j til index i loop nummer 2. Det kunne have været et andet navn, men der bruges ofte bare det bogstav som kommer efter i i alfabetet.
         * Vi angiver hvor længe loop'en skal køre ved at skrive f.eks. index < antal. Og til sidst, skriver vi hvad der skal ske for hvert loop. Her skrives ofte i++.
         * i++ står for i = i + 1, det er blot in kortere måde at skrive det på. Det er altså bare sig selv plus 1 for hvert loop. Gæt hvad i-- står for!
         * Det er altså bare en tæller, som holder styr på, hvor langt vi er kommet i loop'en.
         * Som sagt starter index oftest med 0. Så hvis antallet af runder vi vil have den til at køre er 10, skrives i < 10. Men som sagt, starter jeg fra 1 i stedet for 0 i denne opgave.
         * Ved at sætte i <= 10 kører den ikke kun når tallet er mindre end i, men også når den er lig med 10. 
         * Prøv at lave outputtet om til j i stedet for j*i for at se hvad der bliver udskrevet, og prøv også med i.
         */
        public void print10By10Table()
        {
            for (int i = 1; i <= 10; i++) // Column
            {
                for (int j = 1; j <= 10; j++) // Row
                {
                    Console.Write("{0, 4}", j*i);
                }
                Console.WriteLine();
            }
        }

        ////////////////// Loop Opgave 2 (8)
 
        /* int[] står for et array. Det er altså en række af tal.
         * Vi vil gerne vide hvilket af tallene er det største, som vi har fået med i metoden.
         * Først skal vi vide, hvor mange gange vi skal loop'e. Det kommer an på, hvor mange tal vi har fået.
         * Vi kan finde ud af hvor mange tal vi har fået, ved at tjekke hvor langt array'et er.
         * Hvert tal i array'et har en position. Første position er 0, derefter 1, 2, 3, osv.
         * Vi kan få fat i et bestemt tal i array'et ved at angive positions-numret inde i squarebrackets [] efter array'ets variable navn.
         * Jeg sætter det første tal (fra position 0) til at være det største nummer til videre.
         * Derefter loop'er og tjekker jeg de andre tal. Jeg starter fra position 1 i loop'en da 0 allerede er gemt, og sætter derfor index til at være 1 igen.
         * Hvert gang vi støder på et tal i array'et som er størrer, gemmer vi det nye tal. Vi forsætter til hele array'et er loop'et igennem.
         * Vi returnerer resultat efter loop'en er færdig.
         */
        public int getBiggestNumber(int[] numbers)
        {
            int amountOfNumbers = numbers.Length;
            int biggest = numbers[0];

            for (int i = 1; i < amountOfNumbers; i++)
            {
                if (numbers[i] > biggest)
                {
                    biggest = numbers[i];
                }
            }

            return biggest;
        }


        ////////////////// Opgave 3 (9)

        /* Ligeosm før, skal vi først vide længden på array'et.
         * Vi vil tjekke, om tallet før samt tallet efter er "adjacent" til et bestemt tal. Det betyder dog, at det tal som er på første position (position 0), og det tal,
         * som er på sidste position, skal aldrig tjekkes, da det aldrig vil være adjacent. (De mangler begge en nabo)
         * 
         * Vi vil derfor gerne starte med at tjekke det tal, som er på position 1. Vi sætter derfor index tallet til at være 1.
         * Loop'en skal køre resten af array'et igennem, undtagen den sidste position. Vi sætter derfor et -1 når vi angiver hvor længe loop'en skal køre.
         * 
         * Herefter er det lidt matematik. Vi kigger på det tal loop'en er kommet til.
         * Forstil dig, at vi er på index 1. Vi vil tjekke, om tallet før (index 0) er ét tal mindre, og vi vil tjekke, om tallet efter (index 2) er ét tal størrer.
         * Det vil sige, at hvis vi minuser det tal fra index 1 med det tal fra index 0, bør det give 1, da index 1-tallet skal være 1 større.
         * Og hvis index 1-tallet bliver minuset med index 2-tallet, bør det give -1, da index 1-tallet skal være én mindre.
         * 
         * Hvis begge er sandt, kan vi returnere true.
         */
        public bool ThreeIncreasingAdjacent(int[] numbers)
        {
            int amountOfNumbers = numbers.Length;

            for(int i = 1; i < amountOfNumbers - 1; i++)
            {
                if (numbers[i] - numbers[i-1] == 1 && numbers[i] - numbers[i+1] == -1)
                {
                    return true;
                }
            }
            return false;
        }


        ////////////////// Opgave 4 (10)

        /* Vi skal lave en metode, som returnerer alle de tal, som er lige, fra 0 til 100. Det skal returneres som en STRING!!!
         * Vi laver en loop, som kører 100 gange.
         * Derefter laver vi en tom string, som vi kan tilføje tallene til som vi kommer til dem. Der laves et mellemrum efter tallet så det er nemmere at læse i consollen.
         * Vi bruger vores dejlige ven % for at tjekke om tallet er lige!.
         * Du kan se vi bruger +=
         * I dette tilfælde betyder det samme som msg = msg + i + " ";
         * Den gemmer blot dens gamle værdi sammen med den nye værdi, i stedet for at blive overskrivet hver gang der er et nyt tal.
         */
        public string printEvenNumbers()
        {
            string msg = "";
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    msg += i + " ";
                }
            }
            return msg;
        }

        ////////////////// Opgave 5 (11)

        /*
         * I dunno! Tror man skal forstå det grundlæggende hvordan bits virker for at lave denne ;)
         */
        public int bitsToNumber(int bits)
        {
            return bits;

        }


        ////////////////// Opgave 6 (12)

        /*
         * Jeg har fundet ud af at den godt kan finde det. Det næste problem er bare at få lavet den der string haha.
         * .....Brain still loading.....
         * Løst.
         */

        public string extractString(string message)
        {
            int lengthOfMessage = message.Length;
            string extracted = "";

            for(int i = 1; i < lengthOfMessage-1; i++)
            {
                if (message[i] == '#' && message[i-1] == '#')
                {
                    for (int j = i+1; j < lengthOfMessage-1; j++)
                    {
                        if (message[j] == '#' && message[j+1] == '#')
                        {
                            return extracted;
                        }
                        else
                        {
                            extracted += message[j];
                        }
                    }
                }
            }
            return "";
        }
    }
}
