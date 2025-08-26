﻿namespace Catalog.Api.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<string> Category { get; set; } = new List<string>();
        public string Description { get; set; } = string.Empty;
        public string ImageFile { get; set; } = string.Empty;
        public decimal Price { get; set; } = decimal.Zero;
                
    }
}
