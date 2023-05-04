using Optimum_Tech.Model.Interfaces;
using System;

namespace Optimum_Tech.Model.Products
{
    public abstract class Product : IProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Responses { get; set; }
        public int Rating { get; set; }
        public bool IsAvailable { get; set; }
        public string ImageResourceName { get; set; }
    }
}
