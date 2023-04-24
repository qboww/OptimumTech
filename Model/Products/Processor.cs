namespace Optimum_Tech.Model.Products
{
    public class Processor : Product
    {
        public string Manufacturer { get; set; } = string.Empty;
        public string Socket { get; set; } = string.Empty;
        public int Cores { get; set; }
        public int Threads { get; set; }
        public double ClockSpeedDefault { get; set; }
        public double ClockSpeedBoost { get; set; }
    }
}