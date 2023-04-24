using Newtonsoft.Json;
using Optimum_Tech.Model.Products;
using Optimum_Tech.Model;
using OptimumTech.Controls;

namespace Optimum_Tech.View.Displays
{
    public partial class FormDisplayGraphicsCards : Form
    {
        private readonly string graphicsCardsPath = "D:\\Downloads\\OptimumTech\\Repository\\Products\\graphicscards.json";

        public FormDisplayGraphicsCards()
        {
            InitializeComponent();
        }

        public List<ProductControl> GetGraphicsCards(string jsonFilePath)
        {
            string json = File.ReadAllText(jsonFilePath);
            List<GraphicsCard>? graphicsCards = JsonConvert.DeserializeObject<List<GraphicsCard>>(json);
            List<ProductControl> controls = new List<ProductControl>();

            foreach (GraphicsCard graphicsCard in graphicsCards)
            {
                ProductControl control = new ProductControl(graphicsCard);
                controls.Add(control);
            }

            return controls;
        }


        private void FormDisplayGraphicsCards_Load(object sender, EventArgs e)
        {
            foreach (var control in this.GetGraphicsCards(graphicsCardsPath))
            {
                flowLayoutPanel1.Controls.Add(control);
            }
        }
    }
}
