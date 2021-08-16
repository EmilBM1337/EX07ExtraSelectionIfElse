using System;

namespace EX07ExtraSelectionIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 50;
            Console.WindowWidth = 200;

            Console.WriteLine("Velkommen til mit program!");
            Console.WriteLine("");
            Console.WriteLine("Tast et bogstav for det du ønsker, og afslut med enter.");
            Console.WriteLine("a) Velkomstbesked.");
            Console.WriteLine("b) Udregning af BMI.");
            Console.WriteLine("c) Størst af to tal.");
            string options = Console.ReadLine();
                        
            if (options.Equals("a"))
            {
                Console.WriteLine("");
                Console.WriteLine("Du har valgt: Velkomstbesked.");
                Console.WriteLine("");                
                Console.WriteLine("Indtast dit fornavn efterfulgt af enter.");
                Console.WriteLine("");
                string forNavn = Console.ReadLine();
                Console.WriteLine("Indtast dit efternavn efterfulgt af enter.");
                Console.WriteLine("");
                string efterNavn = Console.ReadLine();
                Console.WriteLine($"Velkommen {forNavn}. Jeg kan se dit efter navn er {efterNavn}.");
            }
            else if (options.Equals("b"))
            {
                Console.WriteLine("");
                Console.WriteLine("Du har valgt: Udregning af BMI.");
                Console.WriteLine("");
                Console.WriteLine("Indtast din højde i centimeter (BRUG KOMMA!), efterfulgt af enter.");
                double højde = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Indtast din vægt i kg, efterfulgt af enter.");
                int vægt = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine($"Din BMI er: {vægt / (højde * højde)}.");
                double bmi = vægt / (højde * højde);

                if (bmi < 18.5)
                {                   
                    Console.WriteLine("Du vejer for lidt.");
                }
                else if (bmi >= 18.5 && bmi < 25)
                {
                    Console.WriteLine("Din vægt er passende.");
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    Console.WriteLine("Du er moderat overvægtig.");
                }
                else
                {
                    Console.WriteLine("Du er svært overvægtig.");
                }
            }
            else if (options.Equals("c"))
            {
                Console.WriteLine("");
                Console.WriteLine("Indtast to tal, og jeg skal fortælle hvilket er størst.");
                Console.WriteLine("");
                Console.WriteLine("Indtast et heltal, og afslut med enter.");
                int input1 = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Indtast et heltal, og afslut med enter.");
                int input2 = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (input1 > input2)
                {
                    Console.WriteLine($"Det største tal er {input1}.");
                }
                else if (input2 > input1)
                {
                    Console.WriteLine($"Det største tal er {input2}.");
                }
                else
                {
                    Console.WriteLine("De to tal er ens.");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("ERROR");
            }
        }
    }
}
