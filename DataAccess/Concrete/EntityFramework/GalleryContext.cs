using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class GalleryContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=Gallery;Trusted_Connection=True");
        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Color> Product { get; set; }
    }
}
