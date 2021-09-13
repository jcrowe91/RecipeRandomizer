using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeRandomizer
{
    public class RecipeBook
    {
        public string Name { get; set; }
        public int Days { get; set; }


        public RecipeBook(string name, int days)
        {
            Name = name;
            Days = days;
        }
    }
}
