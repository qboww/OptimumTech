using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum_Tech.Model
{
    public abstract class Category
    {
        public Category(bool isFavorite, bool isSelected, string imageResourceName) 
        {
            IsSelected = isSelected;
            IsFavorite = isFavorite;
            ImageResourceName = imageResourceName;
        }

        public abstract string Name { get; set; }
        public abstract decimal Price { get; set; }
        public abstract int Responses { get; set; }
        public abstract int Rating { get; set; }
        public bool IsFavorite { get; set; } = false;
        public bool IsSelected { get; set; } = false;
        public string ImageResourceName { get; set; }
        public bool Available { get; set; } = true;
    }
}
