using Optimum_Tech.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimum_Tech.Forms.Dialogs
{
    public partial class FormDescription : Form
    {
        public FormDescription(Processor processor)
        {
            InitializeComponent();

            this.Text = $"Description [{processor.Name}]";

            this.textBoxId.Text = $"Id: {Convert.ToString(processor.Id)}";
            this.textBoxName.Text = $"Name: {processor.Name}";
            this.textBoxPrice.Text = $"Price: {Convert.ToString(processor.Price)}$";
            this.textBoxResponses.Text = $"Responses: {Convert.ToString(processor.Responses)}";
            this.textBoxRating.Text = $"Rating: {Convert.ToString(processor.Rating)} stars";
            this.textBoxManufacturer.Text = $"Manufacturer: {processor.Manufacturer}";
            this.textBoxSeries.Text = $"Series: {processor.Series}";
            this.textBoxSocket.Text = $"Socket: {processor.Socket}";
            this.textBoxCores.Text = $"Cores: {Convert.ToString(processor.Cores)}";
            this.textBoxThreads.Text = $"Threads: {Convert.ToString(processor.Threads)}";
            this.textBoxDefaultSpeed.Text = $"Default speed: {Convert.ToString(processor.ClockSpeedDefault)} MHz";
            this.textBoxBoostSpeed.Text = $"Boost speed: {Convert.ToString(processor.ClockSpeedBoost)} MHz";
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
