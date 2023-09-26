namespace Taschnerechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taschenrechner");
            Console.WriteLine("Welche Rechenart soll ausgeführt werden?: [+, -, *, /]");
            string opperation = Console.ReadLine();
            
            Console.WriteLine("Gebe ersten Wert ein: ");
            double wert1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Gebe zweiten Wert ein: ");
            double wert2 = double.Parse(Console.ReadLine());

            if (opperation == "+")
            {
                double ergsumm = wert1 + wert2;
                Console.WriteLine("Das Ergebnis ist: " + ergsumm);
            }
            else if (opperation == "-")
            {
                double ergsub = wert1 - wert2;
                Console.WriteLine("Das Ergebnis ist: " + ergsub);
            }
            else if (opperation == "*")
            {
                double ergmul = wert1 * wert2;
                Console.WriteLine("Das Ergebnis ist: " + ergmul);
            }
            else if (opperation == "/")
            {
                double ergdivi = wert1 / wert2;
                
                if (wert2 == 0)
                {
                    Console.WriteLine("------------------infinity---------------------");
                }
                else
                {
                    Console.WriteLine("Das Ergebnis ist: " + ergdivi);
                }
                
            }
            else 
            {
                Console.WriteLine("Das ist keine akzeptierte Rechenart");
                Environment.Exit(0);
            }

            Console.ReadKey();
        }
    }
}
