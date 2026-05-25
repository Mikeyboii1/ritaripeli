using System;
using System.Collections.Generic;

namespace RitariPeli
{
    internal class Shop
    {
        private List<Item> items = new List<Item>();

        public Shop()
        {
            items.Add(new Arrow("Perusnuoli", 3, 2));
            items.Add(new Arrow("Hieno nuoli", 10, 5));

            items.Add(new Food("Leipä", 5, 5));

            items.Add(new Weapon("Kirves", 15, 5));
        }

        public void OpenShop(Player player)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nKaupan tavarat:");

                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {items[i].Name} {items[i].Price} kr");
                }

                Console.WriteLine("0: Poistu");

                Console.Write("> ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    running = false;
                    continue;
                }

                Item selectedItem = items[choice - 1];

                if (player.Gold >= selectedItem.Price)
                {
                    player.Gold -= selectedItem.Price;
                    player.Backpack.Add(selectedItem);

                    Console.WriteLine($"Ostit tavaran {selectedItem.Name}");
                }
                else
                {
                    Console.WriteLine("Ei tarpeeksi kultaa.");
                }
            }
        }
    }
}