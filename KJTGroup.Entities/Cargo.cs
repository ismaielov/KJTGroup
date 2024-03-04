namespace KJTGroup.Entities
{
    public class Cargo
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();




    }
}
