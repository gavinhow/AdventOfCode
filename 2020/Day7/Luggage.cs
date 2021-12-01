namespace Day7
{
    public class Luggage
    {
        public string Id;
        public int? Quantity;

        public Luggage(string id, int? quantity = null)
        {
            Id = id;
            Quantity = quantity;
        }
    }
}