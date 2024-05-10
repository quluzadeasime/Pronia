using Pronia.Core.Models;
using Pronia.Core.RepositoryAbstracts;
using Pronia.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Data.RepositoryConcretes
{
    public class CategoryRespository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRespository(AppDbContext context) : base(context)
        {
        }
    }
}
