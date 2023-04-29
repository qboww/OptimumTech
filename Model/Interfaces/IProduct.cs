using Optimum_Tech.Model.Products;

namespace Optimum_Tech.Model.Interfaces
{
    public interface IProduct
    {
        public interface IProduct
        {
            Guid Id { get; set; }
            string Name { get; set; }
            decimal Price { get; set; }
            int Responses { get; set; }
            int Rating { get; set; }
            bool IsAvailable { get; set; }
            string ImageResourceName { get; set; }
        }
    }
}
