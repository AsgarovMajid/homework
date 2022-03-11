namespace homework.Models
{
    public class Fuel
    {
        public Fuel(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString() => Name;
    }
}
