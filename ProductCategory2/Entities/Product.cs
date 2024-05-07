using System;

namespace ProductsCategory.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Category> Categories { get; set; }
    }
}

