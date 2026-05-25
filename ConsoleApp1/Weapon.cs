namespace RitariPeli
{
    internal class Weapon : Item
    {
        public int Damage;

        public Weapon(string name, int price, int damage)
            : base(name, price)
        {
            Damage = damage;
        }
    }
}