using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceProject.Entities;

namespace ServiceProject.Services
{
    public class CategoryService : ICategoryService
    {
        public int InsertCategory(Category category)
        {
            return category.CategoryId;
        }
    }
}
