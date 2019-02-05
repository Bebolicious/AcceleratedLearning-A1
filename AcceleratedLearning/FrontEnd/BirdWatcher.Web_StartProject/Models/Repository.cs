using System;
using System.Collections.Generic;
using System.Linq;

namespace BirdWatcher.Web.Models
{
    public class Repository
    {
        private readonly ObservationContext _context;

        public Repository(ObservationContext context)
        {
            _context = context;
        }

        public void Add(Observation observation)
        {
            _context.Add(observation);
            _context.SaveChanges();
        }
        
        public void RecreateDatabase()
        {
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
        }

        public IEnumerable<Observation> GetAll()
        {
            return _context.Observations; 
        }

    }
}
