using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net;

namespace Optimum_Tech.View.Forms
{
    public partial class FormContact : Form
    {
        public FormContact()
        {
            InitializeComponent();
        }

        private async Task LoadDonationDataAsync()
        {
            using (var client = new WebClient())
            {
                string apiUrl = "https://api.monobank.ua/bank/jar/tLvwiuWMjvJQzaRFERTVS1EqjiCep8";
                client.Headers.Add("X-Token", "uoWF_3gNOCSuM6KpLta-sOcZWAdnyflK4X73zdwenL8c");
                string jsonData = await client.DownloadStringTaskAsync(apiUrl);

                JObject data = JObject.Parse(jsonData);
                int amount = (int)data["amount"];
                int goal = (int)data["goal"];
                string owner = (string)data["ownerName"];
                string name = (string)data["title"];

                double value = ((double)amount / goal) * 100;

                textBoxCurrent.Text = $"{amount / 100}₴ ({value:0.00}%)";
                textBoxGoal.Text = $"{goal / 100}₴";
                textBoxOwner.Text = $"{owner}";
                textBoxName.Text = $"{name}";

                progressBar1.Minimum = 0;
                progressBar1.Maximum = goal;
                progressBar1.Value = amount;
            }
        }

        private async void FormContact_Load(object sender, EventArgs e)
        {
            await LoadDonationDataAsync();
        }

        private void pictureBoxTelegram_Click(object sender, EventArgs e)
        {
            string url = "https://t.me/yevhenko";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
        private void pictureBoxInstagram_Click(object sender, EventArgs e)
        {
            string url = "https://instagram.com/evhenii.sara?igshid=NjNlMDhmYTc=";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/profile.php?id=100013268732329";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
        private void linkLabelDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://send.monobank.ua/jar/LHAfJ6J5c";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
