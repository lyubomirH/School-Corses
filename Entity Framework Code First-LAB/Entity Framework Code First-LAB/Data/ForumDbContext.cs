using Entity_Framework_Code_First_LAB.Configration;
using Entity_Framework_Code_First_LAB.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Code_First_LAB.Data
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext() 
        {
            this.Database.EnsureDeleted();
            //this.Database.EnsureCreated();
        }
        public ForumDbContext(DbContextOptions<ForumDbContext> options)
            :base(options)
        {
            
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PostAnswer> PostAnswers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ForumConfiguration.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new List<User>
            {
                new User() { Id = 1, Username = "Pesho_13", Email = "Email@gmail.com"},
                new User() { Id = 2, Username = "Gosho_15", Email = "gosho@gmail.com"},
                new User() { Id = 3, Username = "Bob_12", Email = "Bob@gmail.com"},
                new User() { Id = 4, Username = "Terminator", Email = "Terminator1999@gmail.com"}
            });
            modelBuilder.Entity<Post>().HasData(new List<Post>
            {
                new Post()
                {
                    Id = 1,
                    PostContent = "Hello, this is my first post in this awesome app!!!",
                    UserId = 2
                },
                new Post()
                {
                    Id = 2,
                    PostContent = "Bob is cool",
                    UserId = 4
                },
                new Post()
                {
                    Id = 3,
                    PostContent = "cobom",
                    UserId = 1
                }
            });
            modelBuilder.Entity<PostAnswer>().HasData(new List<PostAnswer> 
            {
                new PostAnswer() 
                { 
                    Id=1,
                    AnswerContent = "bob is not cool",
                    PostId = 2,
                    UserId = 3
                },
                new PostAnswer()
                {
                    Id=2,
                    AnswerContent = "Hahaha you loser _|_",
                    PostId = 1,
                    UserId = 2
                }
            });

            modelBuilder.Entity<PostAnswer>().HasOne(pa => pa.User).WithMany(u => u.Answers).OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Post>().HasOne(x => x.User).WithMany(u => u.Posts);
            base.OnModelCreating(modelBuilder);
        }
    }
}
