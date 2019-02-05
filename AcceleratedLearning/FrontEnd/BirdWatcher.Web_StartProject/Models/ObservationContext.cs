using Microsoft.EntityFrameworkCore;

namespace BirdWatcher.Web.Models
{
    public class ObservationContext :DbContext
    {
        public DbSet<Observation> Observations { get; set; }

        public ObservationContext(DbContextOptions<ObservationContext> options) : base(options)
        {
        }

    }
}

