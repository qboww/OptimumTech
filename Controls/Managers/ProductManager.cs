using Newtonsoft.Json;
using Optimum_Tech.Model.Products;
using Optimum_Tech.Models;
using OptimumTech.Controls;

namespace Optimum_Tech.Controls.Managers
{
    public static class ProductManager
    {
        public static List<Processor> Processors = new List<Processor>();
        public static List<GraphicsCard> GraphicsCards = new List<GraphicsCard>();
        public static List<Product> Products = new List<Product>();

        public static string? processorsPath = @"..\..\..\Repository\processors.json";
        public static string? graphicsCardsPath = @"..\..\..\Repository\graphicscards.json";
        public static string? postFilePath = @"..\..\..\Repository\novapost.json";
        public static string? ordersPath = @"..\..\..\Repository\orders.json";
        public static string? repositoryPath = @"..\..\..\OptimumTech\Repository";

        public static List<Product> LoadProducts()
        {
            foreach (Processor product in GetProcessors())
            {
                Products.Add(product);
            }
            foreach (GraphicsCard product in GetGraphicsCards())
            {
                Products.Add(product);
            }

            return Products;
        }
        private static List<GraphicsCard> GetGraphicsCards()
        {
            string json = File.ReadAllText(graphicsCardsPath);
            GraphicsCards = JsonConvert.DeserializeObject<List<GraphicsCard>>(json);

            return GraphicsCards;
        }
        private static List<Processor> GetProcessors()
        {
            string json = File.ReadAllText(processorsPath);
            Processors = JsonConvert.DeserializeObject<List<Processor>>(json);

            return Processors;
        }

        private static void SaveGraphicsCards()
        {
            List<GraphicsCard> productsToSave = GraphicsCards.ToList();
            string json = JsonConvert.SerializeObject(productsToSave, Formatting.Indented);
            File.WriteAllText(graphicsCardsPath, json);
        }
        private static void SaveProcessors()
        {
            List<Processor> productsToSave = Processors.ToList();
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
            string json = File.ReadAllText(processorsPath);
            List<Processor>? products = JsonConvert.DeserializeObject<List<Processor>>(json);
            List<ProductControl> controls = new List<ProductControl>();

            foreach (Processor processor in products)
            {
                ProductControl control = new ProductControl(processor);
                controls.Add(control);
            }

            return controls;
        }
    }
}
