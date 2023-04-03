using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Optimum_Tech.Model
{
    public class Processor : Category
    {
        public override string Name { get; set; }
        public override decimal Price { get; set; }
        public override int Responses { get; set; }
        public override int Rating { get; set; }

        public string Manufacturer { get; set; }
        public string Series { get; set; }
        public int Cores { get; set; }
        public int Threads { get; set; }
        public string Socket { get; set; }
        public double ClockSpeedDefault { get; set; }
        public double ClockSpeedBoost { get; set; }

        public static List<Processor> Storage { get; } = new List<Processor>();

        static Processor()
        {
            // Initialize the static list of processors by deserializing the JSON file
            string json = File.ReadAllText("D:\\Downloads\\OptimumTech\\Model\\ModelData\\processors.json");
            Storage = JsonConvert.DeserializeObject<List<Processor>>(json);
        }

        public Processor(string name, decimal price, int responses, int rating, string manufacturer, string series,
            bool isFavorite, bool isSelected, int cores, string socket, int threads, double clockSpeedDefault,
            double clockSpeedBoost, string imageResourceName) : base(isFavorite, isSelected, imageResourceName)
        {
            Name = name;
            Price = price;
            Responses = responses;
            Manufacturer = manufacturer;
            Series = series;
            Rating = rating;
            Manufacturer = manufacturer;
            Series = series;

            IsFavorite = isFavorite;
            IsSelected = isSelected;

            Socket = socket;
            Cores = cores;
            Threads = threads;
            ClockSpeedDefault = clockSpeedDefault;
            ClockSpeedBoost = clockSpeedBoost;
            ImageResourceName = imageResourceName;

            // Add this instance of the Processor object to the static list
            Storage.Add(this);
        }
    }
}
