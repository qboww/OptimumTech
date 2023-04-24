using Newtonsoft.Json;
using Optimum_Tech.Model;
using Optimum_Tech.Model.Products;
using OptimumTech.Controls;
using System.DirectoryServices.ActiveDirectory;

namespace Optimum_Tech.Forms
{
    public partial class FormDisplayProcessors : Form
    {
        private readonly string processorsPath = "D:\\Downloads\\OptimumTech\\Repository\\Products\\processors.json";

        public FormDisplayProcessors()
        {
            InitializeComponent();
        }

        public List<ProductControl> GetProcessors(string jsonFilePath)
        {
            string json = File.ReadAllText(jsonFilePath);
            List<Processor>? products = JsonConvert.DeserializeObject<List<Processor>>(json);
            List<ProductControl> controls = new List<ProductControl>();

            foreach (Processor processor in products)
            {
                ProductControl control = new ProductControl((Product)processor);
                controls.Add(control);
            }

            return controls;
        }

        private void FormDisplay_Load(object sender, EventArgs e)
        {
            foreach (var control in this.GetProcessors(processorsPath))
            {
                flowLayoutPanel1.Controls.Add(control);
            }
        }
    }
}