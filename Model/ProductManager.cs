using Newtonsoft.Json;
using Optimum_Tech.Model.Products;
using OptimumTech.Controls;

namespace Optimum_Tech.Model
{
    public static class ProductManager
    {

        public static List<Processor> processors = new List<Processor>();
        public static List<GraphicsCard> graphicsCards = new List<GraphicsCard>();
        public static List<Product> products = new List<Product>();

        public static List<Product> LoadProducts()
        {
            foreach (Processor product in GetProcessors())
            {
                products.Add(product);
            }
            foreach (GraphicsCard product in GetGraphicsCards())
            {
                products.Add(product);
            }

            return products;
        }
        private static List<GraphicsCard> GetGraphicsCards()
        {
            string graphicsCardsPath = "D:\\Downloads\\OptimumTech\\Repository\\Products\\graphicscards.json";

            string json = File.ReadAllText(graphicsCardsPath);
            graphicsCards = JsonConvert.DeserializeObject<List<GraphicsCard>>(json);

            return graphicsCards;
        }
        private static List<Processor> GetProcessors()
        {
            string processorsPath = "D:\\Downloads\\OptimumTech\\Repository\\Products\\processors.json";

            string json = File.ReadAllText(processorsPath);
            processors = JsonConvert.DeserializeObject<List<Processor>>(json);

            return processors;
        }

        private static void SaveGraphicsCards()
        {
            string graphicsCardsPath = "D:\\Downloads\\OptimumTech\\Repository\\Products\\graphicscards.json";

            List<GraphicsCard> productsToSave = graphicsCards.ToList();
            string json = JsonConvert.SerializeObject(productsToSave, Formatting.Indented);
            File.WriteAllText(graphicsCardsPath, json);
        }
        private static void SaveProcessors()
        {
            string processorsPath = "D:\\Downloads\\OptimumTech\\Repository\\Products\\processors.json";

            List<Processor> productsToSave = processors.ToList();
            string json = JsonConvert.SerializeObject(productsToSave, Formatting.Indented);
            File.WriteAllText(processorsPath, json);
        }
        public static void SaveChanges()
        {
            SaveGraphicsCards();
            SaveProcessors();

            MessageBox.Show("Changes saved successfully.");
        }

        public static List<ProductControl> GetGraphicsCardsControls()
        {
            string graphicsCardsPath = "D:\\Downloads\\OptimumTech\\Repository\\Products\\graphicscards.json";

            string json = File.ReadAllText(graphicsCardsPath);
            List<GraphicsCard>? graphicsCards = JsonConvert.DeserializeObject<List<GraphicsCard>>(json);
            List<ProductControl> controls = new List<ProductControl>();

            foreach (GraphicsCard graphicsCard in graphicsCards)
            {
                ProductControl control = new ProductControl(graphicsCard);
                controls.Add(control);
            }

            return controls;
        }
        public static List<ProductControl> GetProcessorsControls()
        {
            string processorsPath = "D:\\Downloads\\OptimumTech\\Repository\\Products\\processors.json";

            string json = File.ReadAllText(processorsPath);
            List<Processor>? products = JsonConvert.DeserializeObject<List<Processor>>(json);
            List<ProductControl> controls = new List<ProductControl>();

            foreach (Processor processor in products)
            {
                ProductControl control = new ProductControl((Product)processor);
                controls.Add(control);
            }

            return controls;
        }
    }
}
