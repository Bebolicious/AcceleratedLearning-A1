using System;
using EfSamurai.Domain;
using EfSamurai.Data;
using System.Linq;
using System.Collections.Generic;

namespace EfSamurai.App
{
    class Program
    {
        static void Main(string[] args)
        {
            AddOneSamurai();
            AddSomeSamurais();
            AddSomeBattles();
            AddOneSamuraiWithRelatedData();
            ClearDatabase();
        }

        private static void AddOneSamuraiWithRelatedData()
        {

            var BattleofChinaevents = new List<BattleEvents>();
            var BattleofChina = new BattleEvents { Description = "The battle of China" };
            BattleofChinaevents.Add(BattleofChina);

            var BattleofChinaLog = new BattleLog
            {
                Name = "Battle of China Logs",
                BattleEvents = BattleofChinaevents,

            };

           // var Djingisquotelist = new List<Quotestext>();
           // Djingisquotelist.Add(Lame);
           // Djingisquotelist.Add(Awesome);
            var Djingis = new Samurai { Name = "Djingis khan", Age = 60, Haircut = Haircut.Oicho };

            var b1 = new Battle
            {
                Name = "Battle of China",
                BattleLog = BattleofChinaLog,
                Startdate = DateTime.Parse("1553/12/10"),
                Enddate = DateTime.Parse("1559/05/25"),
                SamuraiBattles = new List<SamuraiBattle>
                {
                    new SamuraiBattle { Samurai = Djingis},

                }
            };

         using (var context = new SamuraiContext())
            {
                context.Battles.Add(b1);
                context.Samurais.Add(Djingis);
                context.SaveChanges();
            }

           
        }

        public void ClearDatabase()
        {
            foreach (var category in context.FruitCategories)
            {
                _context.Remove(category);
            }

            foreach (var fruit in _context.Fruits)
            {
                _context.Remove(fruit);
            }

            foreach (var basket in _context.Baskets)
            {
                _context.Remove(basket);
            }
        }

        private static void AddSomeBattles()
        {
            var Darkwarevents = new List<BattleEvents>();
            var BattleofMongolia = new BattleEvents { Description = "The final battle for the Mongolian Empire" };
            Darkwarevents.Add(BattleofMongolia);

            var DarkwarLog = new BattleLog { Name = "Dark War Battlelog", BattleEvents = Darkwarevents };
            DateTime darkwartimestart = DateTime.Parse("1573/10/12");
            DateTime darkwartimesend = DateTime.Parse("1575/03/19");

            var Darkwar = new Battle { Name = "The Dark War", Description = "The bloodiest war in histoy", Brutal = true, Startdate = darkwartimestart, Enddate = darkwartimesend, BattleLog = DarkwarLog};



            using (var context = new SamuraiContext())
            {
                context.Battles.Add(Darkwar);
                context.SaveChanges();
            }
        }

        private static void AddSomeSamurais()
        {
            var Shogo = new Samurai { Name = "Sho-Go", Haircut = Haircut.Oicho, Age = 57 };
            var Shohun = new Samurai { Name = "Sho-Hun", Haircut = Haircut.Mohawk, Age = 32 };
            var Jahnnok = new Samurai { Name = "Jahn-Nok", Haircut = Haircut.Chonmage, Age = 65 };

            using (var context = new SamuraiContext())
            {
                context.Samurais.AddRange(Shogo, Shohun, Jahnnok);
                context.SaveChanges();
            }

        }

        private static void AddOneSamurai()
        {

            var samurai = new Samurai { Name = "Sho-Yoko", Haircut = Haircut.Oicho, Age = 57 };

            using (var context = new SamuraiContext())
            {
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }
        }
    }
}
