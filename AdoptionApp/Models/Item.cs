using System;
using System.Collections.Generic;
using System.Text;

namespace AdoptionApp.Models
{
    public class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Desc { get; set; }
        public string Category { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public int UsersId { get; set; }
        public ICollection<Image> ItemImage { get; set; }
    }
}
