namespace RitariPeli
{
    internal class Food : Item
    {
        public int HealAmount;

        public Food(string name, int price, int heal)
            : base(name, price)
        {
            HealAmount = heal;
        }
    }
}