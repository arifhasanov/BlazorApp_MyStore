﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public List<ProductVariant> Variants { get; set; } = new List<ProductVariant>();

    }
}
