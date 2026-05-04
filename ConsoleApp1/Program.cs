namespace RitariPeli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa seikkailuun!");
            // Pelin alussa ritarilla on vain miekka,10 kultarahaa ja 10 osumapistettä.
            int playerHealth = 10;
            int playerWealth = 10;
            Console.WriteLine($"Tilanne: Sinulla on {playerHealth} osumapistettä ja {playerWealth} kultarahaa.");

            Console.WriteLine("Valitse toiminto:");
            Console.WriteLine("1 Mene nuolikauppaan");
            Console.WriteLine("2 Mene ravintolaan");
            Console.WriteLine("3 Lähde taisteluun");
            Console.WriteLine("4 Käytä repussa olevia esineitä");

            // Pelaaja voi kirjoittaa valintansa, ja ohjelma reagoi siihen.
            string choice = Console.ReadLine();

        }
    }
}

