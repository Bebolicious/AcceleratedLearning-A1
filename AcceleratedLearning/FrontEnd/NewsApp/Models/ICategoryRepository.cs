using System.Collections.Generic;

namespace NewsApp.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        Category GetById(int newsCategoryId);
    }
}
