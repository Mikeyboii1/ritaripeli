using System.Collections.Generic;

namespace RitariPeli
{
    internal class Player
    {
        public int Health = 10;
        public int MaxHealth = 10;
        public int Gold = 10;

        public Weapon EquippedWeapon;

        public List<Item> Backpack = new List<Item>();

        public Player()
        {
            EquippedWeapon = new Weapon("Miekka", 0, 2);
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Tilanne: Sinulla on {Health} osumapistettä ja {Gold} kultarahaa.");
        }

        public void ShowInventory()
        {
            if (Backpack.Count == 0)
            {
                Console.WriteLine("Reppu on tyhjä.");
                return;
            }

            Console.WriteLine("Repun tavarat:");

            for (int i = 0; i < Backpack.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {Backpack[i].Name}");
            }
        }
    }
}