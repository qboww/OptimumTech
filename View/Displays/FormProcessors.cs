using Newtonsoft.Json;
using Optimum_Tech.Model;
using Optimum_Tech.Model.Products;
using OptimumTech.Controls;
using System.DirectoryServices.ActiveDirectory;

namespace Optimum_Tech.Forms
{
    public partial class FormProcessors : Form
    {
        private readonly string processorsPath = "D:\\Downloads\\OptimumTech\\Repository\\Products\\processors.json";

        public FormProcessors()
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

        private void FormProcessors_Load(object sender, EventArgs e)
        {
            foreach (var control in this.GetProcessors(processorsPath))
            {
                flowLayoutPanel1.Controls.Add(control);
            }
        }
    }
}