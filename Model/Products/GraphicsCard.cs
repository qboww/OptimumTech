namespace Optimum_Tech.Model.Products
{
    public class GraphicsCard : Product
    {
        public string Manufacturer { get; set; } = string.Empty;
        public int VRAM { get; set; }
        public int MemoryInterface { get; set; }
        public string MemoryType { get; set; } = string.Empty;
        public double ClockSpeedDefault { get; set; }
        public int MinimumWattage { get; set; }
    }
}
