namespace RitariPeli
{
    internal class Monster
    {
        public string Name;
        public int Health;
        public int Damage;

        public Monster(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
    }
}