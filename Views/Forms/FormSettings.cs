using Optimum_Tech.Forms;
using System.Drawing.Text;
using System.Net;
using System.Text;

namespace Optimum_Tech.View.Forms
{
    public partial class FormSettings : Form
    {
        FormHome formHome;
        private static readonly string usersFilePath = @"..\..\Repository\novapost.json";
        public FormSettings(FormHome formHome)
        {
            InitializeComponent();
            this.formHome = formHome;

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"..\..\Fonts\Poppins-Regular.ttf");
        }

        private void buttonBanner_Click(object sender, EventArgs e)
        {
            if (this.textBoxState.Text == "Enabled")
            {
                formHome.panelBanner.Visible = false;
                this.textBoxState.Text = "Disabled";
                this.textBoxState.ForeColor = Color.Red;
            }
            else
            {
                formHome.panelBanner.Visible = true;
                this.textBoxState.Text = "Enabled";
                this.textBoxState.ForeColor = Color.LimeGreen;
            }
        }

        public async Task LoadWarehousesAsync(string usersFilePath)
        {
            this.textBoxStatusAPI.ForeColor = Color.Cyan;
            this.textBoxStatusAPI.Text = "Loading";

            string apiKey = "95674cacee35008e76f181904de2acaf";
            string url = "https://api.novaposhta.ua/v2.0/json/";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";

            string postData = @"
            {                ""apiKey"": """ + apiKey + @""",
                ""modelName"": ""AddressGeneral"",
                ""calledMethod"": ""getWarehouses"",
                ""methodProperties"": {
                    ""Language"": ""ua""
            }
            }";
            byte[] data = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = data.Length;

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(data, 0, data.Length);
            }

            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string responseString = await reader.ReadToEndAsync();
                        File.WriteAllText(usersFilePath, responseString);
                    }
                }
            }

            this.textBoxStatusAPI.ForeColor = Color.LimeGreen;
            this.textBoxStatusAPI.Text = "Updated";
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will take 60 seconds");

            LoadWarehousesAsync(usersFilePath);
        }
    }
}
