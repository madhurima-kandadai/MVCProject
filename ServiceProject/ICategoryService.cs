using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceProject.Entities;

namespace ServiceProject
{
    public interface ICategoryService
    {
        int InsertCategory(Category category);
    }
}
