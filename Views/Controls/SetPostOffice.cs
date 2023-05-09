using HtmlAgilityPack;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Optimum_Tech.Views.Controls
{
    public partial class SetPostOffice : UserControl
    {
        private readonly string usersFilePath = Path.Combine("..", "..", "Repository", "novapost.json");

        public SetPostOffice()
        {
            InitializeComponent();

            listBoxAddresses.Enabled = false;

            FillCitiesComboBox();
        }

        private void SetPostOffice_Load(object sender, EventArgs e)
        {

        }

        private void FillCitiesComboBox()
        {
            var web = new HtmlWeb();
            var doc = web.Load("https://uk.wikipedia.org/wiki/%D0%A1%D0%BF%D0%B8%D1%81%D0%BE%D0%BA_%D0%BC%D1%96%D1%81%D1%82_%D0%A3%D0%BA%D1%80%D0%B0%D1%97%D0%BD%D0%B8");
            var cityNodes = doc.DocumentNode.SelectNodes("//table[contains(@class, 'wikitable')][1]//a[starts-with(@href, '/wiki/') and not(starts-with(@title, 'Файл:'))]");

            var cities = cityNodes
                .Select(node => node.InnerText.Trim())
                .Where(city => !string.IsNullOrWhiteSpace(city) && !char.IsDigit(city[0]) && !Regex.IsMatch(city, @"(?<!\p{L})[IVX]+\b"))
                .Distinct()
                .OrderBy(city => city)
                .ToArray();

            comboBoxCities.Items.AddRange(cities);
        }

        private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAddresses.Items.Clear();

            string selectedCity = comboBoxCities.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(selectedCity))
            {
                string jsonString = File.ReadAllText(usersFilePath);
                dynamic data = JsonConvert.DeserializeObject(jsonString);

                foreach (dynamic office in data.data)
                {
                    string city = office.CityDescription.ToString();

                    if (city == selectedCity)
                    {
                        string address = office.ShortAddress.ToString();
                        listBoxAddresses.Items.Add(address);
                    }
                }
            }

            listBoxAddresses.Enabled = true;
        }
    }
}