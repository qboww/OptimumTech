using Newtonsoft.Json;
using Optimum_Tech.Controls.Managers;
using Optimum_Tech.Forms;
using Optimum_Tech.Model.Products;
using OptimumTech.Controls;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Optimum_Tech.View.Displays
{
    public partial class FormSearch : Form
    {
        public List<ProductControl> searchControls = new List<ProductControl>();
        FormMain formMain;
        Product product;

        public FormSearch(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.product = product;

            flowLayoutPanel1.Controls.Clear();

            GetGraphicsCards(ProductManager.graphicsCardsPath);
            GetProcessors(ProductManager.processorsPath);

            foreach (ProductControl control in searchControls)
            {
                flowLayoutPanel1.Controls.Add(control);
            }
        }

        public void GetGraphicsCards(string path)
        {
            string json = File.ReadAllText(path);
            List<GraphicsCard> graphicsCards = JsonConvert.DeserializeObject<List<GraphicsCard>>(json);

            foreach (GraphicsCard graphicsCard in graphicsCards)
            {
                ProductControl control = new ProductControl(graphicsCard);

                if (graphicsCard.Name.Contains(formMain.textBoxSearchText.Text))
                {
                    searchControls.Add(control);
                }
            }
        }
        public void GetProcessors(string path)
        {
            string json = File.ReadAllText(path);
            List<Processor> processors = JsonConvert.DeserializeObject<List<Processor>>(json);

            foreach (Processor processor in processors)
            {
                ProductControl control = new ProductControl(processor);

                if (processor.Name.Contains(formMain.textBoxSearchText.Text))
                {
                    searchControls.Add(control);
                }
            }
        }
    }
}
