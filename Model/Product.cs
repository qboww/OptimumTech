using Optimum_Tech.Model.Interfaces;
using Optimum_Tech.Model.Products;

namespace Optimum_Tech.Model
{
    public class Product : Processor, IProduct
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Responses { get; set; }
        public int Rating { get; set; }
        public bool IsAvailable { get; set; }
        public string ImageResourceName { get; set; }
        

        public Product(string name, decimal price, int responses, int rating, bool isAvailable, string imageResourceName)
        {
            Name = name;
            Price = price;
            Responses = responses;
            Rating = rating;
            IsAvailable = isAvailable;
            ImageResourceName = imageResourceName;
        }
    }
}
