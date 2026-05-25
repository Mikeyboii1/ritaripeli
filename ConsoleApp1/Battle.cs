using System;

namespace RitariPeli
{
    internal class Battle
    {
        public void StartBattle(Player player)
        {
            Monster monster = new Monster("Goblin", 6, 2);

            Console.WriteLine($"Kohtaat hirviön: {monster.Name}");

            while (monster.Health > 0 && player.Health > 0)
            {
                Console.WriteLine($"\nOma OP: {player.Health}");
                Console.WriteLine($"Vihollinen OP: {monster.Health}");

                Console.WriteLine("1 Hyökkää");
                Console.WriteLine("2 Käytä tavaraa");
                Console.WriteLine("3 Pakene");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    int damage = player.EquippedWeapon.Damage;

                    monster.Health -= damage;

                    Console.WriteLine($"Iskit vihollista ja teit {damage} vahinkoa.");
                }
                else if (choice == "2")
                {
                    player.ShowInventory();

                    Console.Write("> ");
                    int itemChoice = int.Parse(Console.ReadLine());

                    Item item = player.Backpack[itemChoice - 1];

                    if (item is Food food)
                    {
                        player.Health += food.HealAmount;

                        if (player.Health > player.MaxHealth)
                            player.Health = player.MaxHealth;

                        Console.WriteLine($"Söit ruoan ja paranit {food.HealAmount} pistettä.");

                        player.Backpack.Remove(item);
                    }
                    else if (item is Arrow arrow)
                    {
                        monster.Health -= arrow.Damage;

                        Console.WriteLine($"Ammuit nuolen ja teit {arrow.Damage} vahinkoa.");

                        player.Backpack.Remove(item);
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Pakenit taistelusta!");
                    return;
                }

                if (monster.Health > 0)
                {
                    player.Health -= monster.Damage;

                    Console.WriteLine($"{monster.Name} teki {monster.Damage} vahinkoa.");
                }
            }

            if (player.Health <= 0)
            {
                Console.WriteLine("Kuolit. Peli loppui.");
            }
            else
            {
                Console.WriteLine("Voitit hirviön!");
                player.Gold += 5;
            }
        }
    }
}