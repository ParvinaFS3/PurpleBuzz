using FronToBack.Models;
using Microsoft.EntityFrameworkCore;

namespace FronToBack.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
            



        }
        public DbSet<Card> Cards { get; set; }

        public DbSet<ContactIntro> ContactIntro { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet <CategoryComponent> CategoryComponents { get; set; }
        public DbSet <ContactInfo> ContactInfo { get; set; }
        public DbSet <ContactHeader> ContactHeaders { get; set; }

        public DbSet<RecentWorkComponent> RecentWork { get; set; }

    }
}
