using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Data
{
    public class Products
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public CategoryModel Category { get; set; }

        public ICollection<ProductGallery> productGallery { get; set; }
        public string CoverImageUrl { get; set; }
        public string PricechartPdfUrl { get; set; }
    }
}
