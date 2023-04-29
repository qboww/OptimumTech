using Newtonsoft.Json;
using Optimum_Tech.Forms;
using Optimum_Tech.Model.Products;
using OptimumTech.Controls;
using System.Windows.Forms;

namespace Optimum_Tech.View.Displays
{
    public partial class FormSearch : Form
    {
        string graphicsCardsPath = "D:\\Downloads\\OptimumTech\\Repository\\Products\\graphicscards.json";
        string processorsPath = "D:\\Downloads\\OptimumTech\\Repository\\Products\\processors.json";

        List<ProductControl> controls = new List<ProductControl>();
        FormMain formMain;

        public FormSearch(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            GetGraphicsCards(graphicsCardsPath);
            GetProcessors(processorsPath);

            foreach (ProductControl control in controls) 
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

                if (graphicsCard.Name.Contains(formMain.SearchTextBox.Text))
                {
                    controls.Add(control);
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

                if (processor.Name.Contains(formMain.SearchTextBox.Text))
                {
                    controls.Add(control);
                }
            }
        }

    }
}
