using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoka_Marketing.Models
{
    class CategoryModel
    {
        public int Category_id { get; set; }
        public string Name { get; set; }
        public string Detalhes { get; set; }

        public CategoryModel(int category_id, string name, string detalhes = "")
        {
            Category_id = category_id;
            Name = name;
            Detalhes = detalhes;
        }
    }
}
