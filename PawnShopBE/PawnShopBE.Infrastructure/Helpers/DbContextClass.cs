using Microsoft.EntityFrameworkCore;
using PawnShopBE.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopBE.Infrastructure.Helpers
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {

        }
        #region DbSet
        public DbSet<User> User { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Role> Role { get; set; }

        #endregion

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                // Table mapping to db
                entity.ToTable("User");
                // PK
                entity.HasKey(u => u.UserId);
                // Relative
                entity.HasOne(u => u.Branch).WithMany(b =>b.Users).HasForeignKey(u => u.BranchId).IsRequired(false);
                entity.HasOne(u => u.Role).WithMany(r => r.Users).HasForeignKey(r => r.RoleId).IsRequired(true);
            });
            //modelBuilder.Entity<Branch>(entity =>
            //{
            //    entity.ToTable("Branch");
            //    entity.HasKey(b => b.BranchId);
            //    entity.HasMany(u => u.Users).WithOne();
            //});

            //modelBuilder.Entity<Role>(entity =>
            //{
            //    entity.ToTable("Role");
            //    entity.HasKey(r => r.RoleId);
            //    entity.HasMany(u => u.Users).WithOne();
            //});


        }
       
    }
}
