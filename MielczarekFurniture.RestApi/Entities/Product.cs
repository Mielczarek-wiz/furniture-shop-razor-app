﻿namespace MielczarekFurniture.RestApi.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }

        public Producer Producer { get; set; } = new();
    }
}
