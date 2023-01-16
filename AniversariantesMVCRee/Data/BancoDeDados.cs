using AniversariantesMVCRee.Models;
using Microsoft.EntityFrameworkCore;

namespace AniversariantesMVCRee.Data
{
    public class BancoDeDados : DbContext
    {
        public BancoDeDados(DbContextOptions options) : base(options)
        {


        }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amigo>()
                .ToTable("Amigo");

            base.OnModelCreating(modelBuilder);
        }*/
        public DbSet<Amigo> Amigo { get; set; }
    }
}