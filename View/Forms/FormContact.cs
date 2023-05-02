using System.Diagnostics;


namespace Optimum_Tech.View.Forms
{
    public partial class FormContact : Form
    {
        public FormContact()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://t.me/yevhenko";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
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
