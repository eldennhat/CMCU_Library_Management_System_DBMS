using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models.Other
{
    public class Category
    {
        public string IdCategory { get; set; } = string.Empty;
        public string NameCategory { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public Category(string idCategory, string nameCategory, string description)
        {
            IdCategory = idCategory;
            NameCategory = nameCategory;
            Description = description;
        }
    }
}
