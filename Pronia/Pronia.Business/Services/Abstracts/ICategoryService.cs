﻿using Pronia.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Business.Services.Abstracts
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        void DeleteCategory(int id);
        void UpdateCategory(int id, Category category);
        Category GetCategory(Func<Category, bool>? func=null);
        List<Category> GetAllCategories(Func<Category, bool>? func = null);

    }
}
