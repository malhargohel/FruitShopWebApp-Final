using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data;
using WebApplication3.Models;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Enums;
using Microsoft.Extensions.Configuration;
using CURDOperationWithImageUploadCore5_Demo.Data;

namespace WebApplication3.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context = null;
        private readonly IConfiguration _configuration;

        public ProductRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<int> AddNewProduct(ProductModel model)
        {
            var newProduct = new Products()
            {
                CategoryId = model.CategoryId,
                CreatedOn = DateTime.UtcNow,
                Description = model.Description,
                Item = model.Item,
                Price = model.Price.HasValue ? model.Price.Value : 0,
                Quantity = model.Quantity.HasValue ? model.Quantity.Value : 0,
                UpdatedOn = DateTime.UtcNow,
                CoverImageUrl = model.CoverImageUrl,
                PricechartPdfUrl = model.PricechartPdfUrl

            };
            newProduct.productGallery = new List<ProductGallery>();

            foreach (var file in model.Gallery)
            {
                newProduct.productGallery.Add(new ProductGallery()
                {
                    Name = file.Name,
                    URL = file.URL
                });
            }

            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();

            return newProduct.Id;

        }

        public async Task<List<ProductModel>> GetAllProducts()
        {
            return await _context.Products
                  .Select(product => new ProductModel()
                  {
                      CategoryId = product.CategoryId,
                        Category = product.Category.Name,
                        Description = product.Description,
                        Id = product.Id,
                        Item = product.Item,
                        Price = product.Price,
                        Quantity = product.Quantity,
                        CoverImageUrl = product.CoverImageUrl
                  }).ToListAsync();
        }

        public async Task<List<ProductModel>> GetTopProductsAsync(int count)
        {
            return await _context.Products
                  .Select(product => new ProductModel()
                  {
                      CategoryId = product.CategoryId,
                      Category = product.Category.Name,
                      Description = product.Description,
                      Id = product.Id,
                      Item = product.Item,
                      Price = product.Price,
                      Quantity = product.Quantity,
                      CoverImageUrl = product.CoverImageUrl
                  }).Take(count).ToListAsync();
        }


        public async Task<ProductModel> GetProductById(int id)
        {
            return await _context.Products.Where(x => x.Id == id)
                 .Select(product => new ProductModel()
                 {
                     CategoryId = product.CategoryId,
                    Category = product.Category.Name,
                    Description = product.Description,
                    Id = product.Id,
                    Item = product.Item,
                    Price = product.Price,
                    Quantity = product.Quantity,
                     CoverImageUrl = product.CoverImageUrl,

                     Gallery = product.productGallery.Select(g => new GalleryModel()
                     {
                         Id = g.Id,
                         Name = g.Name,
                         URL = g.URL
                     }).ToList(),
                     PricechartPdfUrl = product.PricechartPdfUrl
                 }).FirstOrDefaultAsync();
        }

        public List<ProductModel> SearchProduct(string item, string categoryName)
        {
            return null;
        }
        public string GetAppName()
        {
            return _configuration["AppName"];
        }
    }
}