using OnlineBookStoreWithASPNETCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStoreWithASPNETCore.Interfaces
{
    public interface ICategoryRepository
    {
        List<string> GetCategories();
        Entities.Category GetOrCreateCategoryByName(string name);
    }
}
