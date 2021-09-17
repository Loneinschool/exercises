using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programRunning = true;

            Conditional condi = new();
            Loops loop = new();
            
            while (programRunning)
            {
                Console.WriteLine("Hvilket opgave nummer skal vises? (Indtast tal fra 1 til 12)");
                Console.WriteLine("Tast 0 for at afslutte");
                switch (Console.ReadLine())
                {
                    case "0":
                        programRunning = false;
                        break;
                    case "1":
                        Console.WriteLine("Opgave 1: Absolute Value");
                        Console.WriteLine("Angiv et tal");
                        Console.WriteLine(condi.absoluteValue(int.Parse(Console.ReadLine())));
                        break;
                    case "2":
                        Console.WriteLine("Opgave 2: Divisible by 2 or 3.");
                        Console.WriteLine("Angiv et tal");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Angiv endnu et tal");
                        int num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine(condi.divisibleBy2Or3(num1, num2));
                        break;
                    case "3":
                        Console.WriteLine("Opgave 3: Leap Year");
                        Console.WriteLine("Angiv et årstal");
                        Console.WriteLine(condi.ifYearIsLeap(int.Parse(Console.ReadLine())));
                        break;
                    case "4":
                        Console.WriteLine("Opgave 4: isLonelyIsland");
                        Console.WriteLine(condi.isLonelyIsland("Smuck"));
                        Console.WriteLine(condi.isLonelyIsland("ABC"));
                        break;
                    case "5":
                        Console.WriteLine("Opgave 5: Uppercase Letters");
                        Console.WriteLine("Skriv noget!");
                        Console.WriteLine(condi.ifConsistsOfUppercaseLetters(Console.ReadLine()));
                        break;
                    case "6":
                        Console.WriteLine("Opgave 6: Contains 3?");
                        Console.WriteLine("Skriv et tal!");
                        int checkNumer = int.Parse(Console.ReadLine());
                        Console.WriteLine(condi.checkIfCountains3(checkNumer));
                        break;
                    case "7":
                        Console.WriteLine("Opgave 7: 10 by 10 table");
                        loop.print10By10Table();
                        break;
                    case "8":
                        Console.WriteLine("Opgave 8: Biggest Number");
                        Console.WriteLine(loop.getBiggestNumber(new int[] { 500, 14, 601, 1, 50 }));
                        Console.WriteLine(loop.getBiggestNumber(new int[] { 4, 14, 703, 11, 40 }));
                        Console.WriteLine(loop.getBiggestNumber(new int[] { -20, -40, -1, -3, -100 }));
                        break;
                    case "9":
                        Console.WriteLine("Opgave 9: ThreeIncreasingAdjacent");
                        Console.WriteLine(loop.ThreeIncreasingAdjacent(new int[] { 10, 11, 12 }));
                        Console.WriteLine(loop.ThreeIncreasingAdjacent(new int[] { 9, 11, 12 }));
                        Console.WriteLine(loop.ThreeIncreasingAdjacent(new int[] { 0, 10, 11, 12, 10, 13 }));
                        Console.WriteLine(loop.ThreeIncreasingAdjacent(new int[] { 100, 15, 16, 17 }));
                        break;
                    case "10":
                        Console.WriteLine("Opgave 10: printEvenNumbers");
                        Console.WriteLine(loop.printEvenNumbers());
                        break;
                    case "11":
                        Console.WriteLine("Opgave 11: bitsToNumber");
                        Console.WriteLine("I have no ideaaaaaaaaaa");
                        //Console.WriteLine(loop.bitsToNumber(10));
                        break;
                    case "12":
                        Console.WriteLine("Opgave 12: extractString");
                        Console.WriteLine(loop.extractString("##123##")); //True
                        Console.WriteLine(loop.extractString("##SoTrueYo##")); //True
                        Console.WriteLine(loop.extractString("3##385685##")); // True
                        Console.WriteLine(loop.extractString("#3#"));
                        Console.WriteLine(loop.extractString("##Hej"));
                        Console.WriteLine(loop.extractString("Hej##"));
                        Console.WriteLine(loop.extractString("##Hej#Hej#"));
                        break;
                    default:
                        Console.WriteLine("Der er ingen opgave med det nummer!");
                        break;
                }
            }
        }
    }
}
