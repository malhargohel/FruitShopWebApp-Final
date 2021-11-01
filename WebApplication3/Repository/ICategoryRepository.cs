using WebApplication3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Repository
{
    public interface ICategoryRepository
    {
        Task<List<CategoryModel>> GetCategories();
    }
}
