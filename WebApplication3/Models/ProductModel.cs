using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Enums;
using Microsoft.AspNetCore.Http;

namespace WebApplication3.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required(ErrorMessage = "Please enter the Item Name of the Product (Min 3 Char)")]
        public string Item { get; set; }


        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please select the category name")]
        public CategoryEnum CategoryEnum { get; set; }
        public string Category { get; set; }

        [Display(Name = "Choose the cover photo of your item")]
        [Required]
        public IFormFile CoverPhoto { get; set; }
        public string CoverImageUrl { get; set; }



        [StringLength(500)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter the price")]
        public int? Price { get; set; }

        [Required(ErrorMessage = "Please enter the total quantity left")]
        [Display(Name = "Total amount left")]
        public int? Quantity { get; set; }

        [Display(Name = "Choose the gallery images of your product")]
        [Required]
        public IFormFileCollection GalleryFiles { get; set; }

        public List<GalleryModel> Gallery { get; set; }

        [Display(Name = "Upload the price chart of this product in pdf format")]
        [Required]
        public IFormFile PricechartPdf { get; set; }
        public string PricechartPdfUrl { get; set; }
    }
}
