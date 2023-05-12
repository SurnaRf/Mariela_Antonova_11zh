using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer
{
	public class GameWorldDbContext : DbContext
	{
        public GameWorldDbContext() : base()
        {
            
        }

        public GameWorldDbContext(DbContextOptions contextOptions) : base(contextOptions)
        {
            
        }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Server=DESKTOP-F3IKLD2;Database=GameWorldDb;Trusted_Connection=True;");
			}
			
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

        public DbSet<Game> Games { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Genre> Genres { get; set; }
    }
}
