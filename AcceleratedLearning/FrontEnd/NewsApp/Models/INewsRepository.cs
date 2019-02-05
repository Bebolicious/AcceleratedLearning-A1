using System.Collections.Generic;

namespace NewsApp.Models
{
    public interface INewsRepository
    {
        IEnumerable<News> GetAll();
        News GetById(int id);
        void Add(News news);
        void Update(News news);
        void Remove(int id);
        bool NewsExist(int id);
        int Count();
    }
}
