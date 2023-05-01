using Optimum_Tech.Model;
using Optimum_Tech.Model.Products;

namespace Optimum_Tech.Controls
{
    public partial class EditGraphicsCard : UserControl
    {
        GraphicsCard gpu;
        public EditGraphicsCard(GraphicsCard gpu)
        {
            InitializeComponent();

            this.gpu = gpu;

            this.textBoxId.Text = $"{gpu.Id}";
            this.textBoxName.Text = $"{gpu.Name}";
            this.textBoxPrice.Text = $"{gpu.Price}";
            this.textBoxResponses.Text = $"{gpu.Responses}";
            this.textBoxRating.Text = $"{gpu.Rating}";
            this.textBoxAvailable.Text = $"{gpu.IsAvailable}";

            this.textBoxManufacturer.Text = $"{gpu.Manufacturer}";
            this.textBoxVRAM.Text = $"{gpu.VRAM}";
            this.textBoxMemoryInterface.Text = $"{gpu.MemoryInterface}";
            this.textBoxMemoryType.Text = $"{gpu.MemoryType}";
            this.textBoxClockSpeedDefault.Text = $"{gpu.ClockSpeedDefault}";
            this.textBoxMinimumWattage.Text = $"{gpu.MinimumWattage}";
        }
    }
}
