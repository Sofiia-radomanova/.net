namespace OrdersLibrary.Models
{
    public class OrderItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public OrderItem(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double GetTotal()
        {
            return Price* Quantity;
        }
    }
}
