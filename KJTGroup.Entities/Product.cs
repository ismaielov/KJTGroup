using KJTGroup.Helpers;

namespace KJTGroup.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public ProductType Type { get; set; }
        

        public string Description { get; set; }
    

        public int Quantity { get; set; }



        public decimal Weight { get; set; }

        public decimal Price { get; set; }


    }
}
