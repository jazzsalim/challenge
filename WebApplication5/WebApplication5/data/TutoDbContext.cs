using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;

namespace WebApplication5.data
{
    public class TutoDbContext : DbContext
    {
        public TutoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<personne> personnes {get ; set;}
    }
}
