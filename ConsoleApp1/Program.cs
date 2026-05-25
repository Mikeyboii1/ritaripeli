namespace RitariPeli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Shop shop = new Shop();

            Battle battle = new Battle();

            bool gameRunning = true;

            Console.WriteLine("Tervetuloa suureen seikkailuun!");

            while (gameRunning)
            {
                player.ShowStatus();

                Console.WriteLine("\nValitse toiminto:");
                Console.WriteLine("1 Mene kauppaan");
                Console.WriteLine("2 Lähde taisteluun");
                Console.WriteLine("3 Näytä reppu");
                Console.WriteLine("4 Lopeta peli");

                Console.Write("> ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        shop.OpenShop(player);
                        break;

                    case "2":
                        battle.StartBattle(player);

                        if (player.Health <= 0)
                        {
                            gameRunning = false;
                        }

                        break;

                    case "3":
                        player.ShowInventory();
                        break;

                    case "4":
                        gameRunning = false;
                        break;
                }
            }

            Console.WriteLine("Peli päättyi.");
        }
    }
}