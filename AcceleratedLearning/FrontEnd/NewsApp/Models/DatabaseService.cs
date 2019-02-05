using System;

namespace NewsApp.Models
{
    public class DatabaseService : IDatabaseService
    {
        private readonly DatabaseContext context;

        public DatabaseService(DatabaseContext context)
        {
            this.context = context;
        }

        public void RecreateDatabase()
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        public void ClearAll()
        {
            foreach (var news in context.News)
            {
                context.Remove(news);
            }
            foreach (var category in context.Categories)
            {
                context.Remove(category);
            }
            context.SaveChanges();
        }

        public void SeedRepo()
        {
            ClearAll();

            var nature = new Category
            {
                Name="Nature"
            };

            context.News.Add(new News
            {
                Header = "Grizzly restored",
                Intro = "Yellowstone grizzly bears' protection restored and hunts halted",
                Body = "A US judge has ordered protection to be restored to grizzly bears in and around Yellowstone National Park, blocking plans for the first hunts there in nearly 30 years",
                CreatedDate = new DateTime(2018, 9, 23),
                UpdatedDate = new DateTime(2018, 9, 25),
                Category = nature
            });

            context.News.Add(new News
            {
                Header = "Worst place",
                Intro = "The worst place to be stranded at sea?",
                Body = "Indian yachtsman Abhilash Tomy has been rescued after his boat was severely damaged nearly 2,000 miles (3,200km) off the coast of Western Australia. Is there any worse place to get stranded?",
                CreatedDate = new DateTime(2017, 2, 3),
                UpdatedDate = new DateTime(2017, 2, 5),
                Category =  new Category
                {
                    Name="Australia"
                }
            });
            context.News.Add(new News
            {
                Header = "One nature news",
                Intro = "Bla bla bla",
                Body = "Bla bla bla",
                CreatedDate = new DateTime(2018, 7, 13),
                UpdatedDate = new DateTime(2018, 7, 15),
                Category = nature
            });
            context.News.Add(new News
            {
                Header = "No category",
                Intro = "Bla bla bla",
                Body = "Bla bla bla",
                CreatedDate = new DateTime(2016, 1, 2),
                UpdatedDate = new DateTime(2016, 1, 3),
            });
            context.SaveChanges();
        }

    }
}
