namespace Optimum_Tech.Model.Interfaces
{
    public interface IProduct
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Responses { get; set; }
        public int Rating { get; set; }
        public bool IsAvailable { get; set; }
        public string ImageResourceName { get; set; }
    }
}
