namespace Optimum_Tech.Model.Products
{
    public class GraphicsCard : Product
    {
        private string manufacturer;
        private int vram;
        private int memoryInterface;
        private string memoryType;
        private double clockSpeed;
        private int minimumWattage;

        public string Manufacturer
        {
            get => manufacturer;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(nameof(Manufacturer), "Manufacturer can't be null or empty value!");

                manufacturer = value;
            }
        }
        public int VRAM
        {
            get => vram;
            set
            {
                if (value < 1 || value > 26)
                    throw new ArgumentOutOfRangeException("VRAM can only be in range [1-26]");

                vram = value;
            }
        }
        public int MemoryInterface
        {
            get => memoryInterface;
            set
            {
                if (value < 32 || value > 1024)
                    throw new ArgumentOutOfRangeException("MemoryInterface can only be in range [32-1024]");

                memoryInterface = value;
            }
        }
        public string MemoryType
        {
            get => memoryType;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("MemoryType can't be null or empty value!");

                memoryType = value;
            }
        }
        public double ClockSpeed
        {
            get => clockSpeed;
            set
            {
                if (value < 0.1 || value > 6)
                    throw new ArgumentOutOfRangeException("ClockSpeed can only be in range [0.1-6]");

                clockSpeed = value;
            }
        }
        public int MinimumWattage
        {
            get => minimumWattage;
            set
            {
                if (value < 100 || value > 2000)
                    throw new ArgumentOutOfRangeException("MinimumWattage can only be in range [100-2000]");

                minimumWattage = value;
            }
        }
    }
}
