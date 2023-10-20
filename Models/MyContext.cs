using System.Collections.Generic;
using System.Reflection.Metadata;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Social_App.Models
{
    // the MyContext class represents a session with our MySQL database, allowing us to query for or save data
    // DbContext is a class that comes from EntityFramework, we want to inherit its features
    public class MyContext : DbContext
    {
        // This line will always be here. It is what constructs our context upon initialization
        public MyContext(DbContextOptions options) : base(options) { }
        // We need to create a new DbSet<Model> for every model in our project that is making a table
        // The name of our table in our database will be based on the name we provide here
        // This is where we provide a plural version of our model to fit table naming standards    
        public DbSet<User> Users { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // For Self-Reference Many-to-Many
            // One-to-Many Relationship (User to Follow)
            modelBuilder.Entity<Follow>()
                .HasOne(u => u.Followee)
                .WithMany(u => u.Followers)
                .HasForeignKey(u => u.FollowerId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete;

            // One-to-Many Relationship (Follow to User)
            modelBuilder.Entity<Follow>()
                .HasOne(u => u.Follower)
                .WithMany(u => u.Follows)
                .HasForeignKey(u => u.FolloweeId)
                .OnDelete(DeleteBehavior.Cascade);
            
            /**
             * Tried to configure a unique relationship
             * Post has many Comment
             * Post has one to one Comment
             * MySQL workbench shows this as double many to many :(
             */
            // One-to-Many Relationship (Comment to Post)
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Op)
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.OpId)
                .OnDelete(DeleteBehavior.Cascade); 

            // One-to-One Relationship (Post to Comment)
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Op)
                .WithOne(c => c.Reply)
                .HasForeignKey<Comment>(c => c.ReplyId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}