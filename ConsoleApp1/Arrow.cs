namespace RitariPeli
{
    internal class Arrow : Item
    {
        public int Damage;

        public Arrow(string name, int price, int damage)
            : base(name, price)
        {
            Damage = damage;
        }
    }
}