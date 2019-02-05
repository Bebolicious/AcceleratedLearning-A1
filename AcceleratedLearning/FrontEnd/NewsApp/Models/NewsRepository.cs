using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NewsApp.Models
{
    public class NewsRepository : INewsRepository
    {
        private readonly DatabaseContext context;

        public NewsRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public void Add(News news)
        {
            context.Add(news);
            context.SaveChanges();
        }

        public int Count()
        {
            return context.News.ToList().Count;
        }

        public IEnumerable<News> GetAll()
        {
            return context.News.Include(x=>x.Category); // Krävs för att få med kategorin i controllern
        }

        public News GetById(int id)
        {
            return context.News.Include(x => x.Category).Single(n => n.Id == id);
        }

        public bool NewsExist(int id)
        {
            return context.News.Any(n=>n.Id == id);
        }

        public void Remove(int id)
        {
            News n = GetById(id);
            context.News.Remove(n);
            context.SaveChanges();
        }

        public void Update(News news)
        {
            context.Update(news);
            context.SaveChanges();
        }
    }
}
