namespace KJTGroup.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


        public int CxPhoneNumber
        {
            get
            {
                return Customer.PhoneNumber;
            }
        }


        public string Description { get; set; }

        public decimal Price { get; set; }

        public int ProductId { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();





    }
}
