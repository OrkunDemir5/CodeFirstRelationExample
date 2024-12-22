using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelationExample.Data
{
    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=PatikaCodeFirstDb2");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // User - Post Relationship
            modelBuilder.Entity<Post>()
                .HasOne(p => p.User) 
                .WithMany(u => u.Posts) 
                .HasForeignKey(p => p.UserId); 
            //modelBuilder.Entity<Post>().HasData(
            //    new Post() { Title = "Ilk Post", Content = "Hello World!" },
            //    new Post() { Title = "Ikinci Post", Content = "Hello Moon!" }
            //    );
            //modelBuilder.Entity<User>().HasData(
            //    new User() { Username = "Orkun Demir", Email = "orkun.d1999@gmail.com" },
            //    new User() { Username = "Ahmet Mehmet", Email = "ahmetmehmet9@gmail.com" }
            //    );
        }
    }
}
