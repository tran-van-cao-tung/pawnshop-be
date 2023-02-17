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
        public DbSet<RefeshToken> RefeshTokens { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<DependentPeople> DependentPeople { get; set; }
        public DbSet<Job > Job { get; set; }
        public DbSet<CustomerRelativeRelationship> CustomerRelativeRelationship { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Kyc> Kyc { get; set; }
        public DbSet<Liquidtation> Liquidtation { get; set; }
        public DbSet<Core.Models.Attribute> Attribute { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<ContractAsset> ContractAsset { get; set; }
        public DbSet<DependentPeople> DependentPeoples { get; set; }
        public DbSet<InterestDiary> InterestDiaries { get; set; }
        public DbSet<Ledger> Ledgers { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PawnableProduct> PawnableProducts { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        #endregion

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Branch
            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("Branch");
                entity.HasKey(b => b.BranchId);
                //  entity.HasMany(u => u.Users).WithOne();
            });
            //Role
            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");
                entity.HasKey(r => r.RoleId);
                // entity.HasMany(u => u.Users).WithOne();
            });
            //User
            modelBuilder.Entity<User>(entity =>
            {
                // Table mapping to db
                entity.ToTable("User");
                // PK
                entity.HasKey(u => u.UserId);
                // Relative
                entity.HasOne(u => u.Branch)
                .WithMany(b =>b.Users)
                .HasForeignKey(u => u.BranchId).IsRequired(false);

                entity.HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(r => r.RoleId).IsRequired(true);
            });
            //Leger
            modelBuilder.Entity<Ledger>(en =>
            {
                en.ToTable("Ledger");
                en.HasKey(r => r.LedgerId);
                //Relative
                en.HasOne(e => e.Branch)
                .WithMany(e => e.Ledgers)
                .HasForeignKey(e => e.BranchId)
                .HasConstraintName("Fk_Ledger_Branch");
            });
            //InteresDiary
            modelBuilder.Entity<InterestDiary>(en =>
            {
                en.ToTable("InteresDiary");
                en.HasKey(e => e.InterestDiaryId);
                //Relative
                en.HasOne(e => e.Contract)
                .WithMany(e => e.InterestDiaries)
                .HasForeignKey(e => e.ContractId)
                .HasConstraintName("Fk_InterestDiary_Contract");
            });
            //Package
            modelBuilder.Entity<Package>(en => {
                en.ToTable("Package");
                en.HasKey(e=> e.PackageId);
            });
            //Liquidation
            modelBuilder.Entity<Liquidtation>(en =>
            {
                en.ToTable("Liquidation");
                en.HasKey(e => e.LiquidationID);
                //Relative
                en.HasOne(e => e.Contract)
                .WithOne(e => e.Liquidtation)
                .HasForeignKey<Liquidtation>(e => e.ContractID)
                .HasConstraintName("Fk_Liquidation_Contract");
            });
            //PawnableProduct
            modelBuilder.Entity<PawnableProduct>(en =>
            {
                en.ToTable("PawnableProduct");
                en.HasKey(e => e.PawnableProductId);
            });
            //Attribute
            modelBuilder.Entity<Core.Models.Attribute>(en =>
            {
                en.ToTable("Attribute");
                en.HasKey(e => e.AttributeId);
                //relative
                en.HasOne(e => e.PawnableProduct)
                .WithMany(e => e.Attributes)
                .HasForeignKey(e => e.PawnableProductID)
                .HasConstraintName("Fk_PawnableProduct_Attribute");
            });
            //WareHouse
            modelBuilder.Entity<Warehouse>(en =>
            {
                en.ToTable("WareHouse");
                en.HasKey(e => e.WarehouseId);
            });
            //Contract Asset
            modelBuilder.Entity<ContractAsset>(en =>
            {
                en.ToTable("ContractAsset");
                en.HasKey(e => e.ContractAssetId);
                //relative
                en.HasOne(e => e.PawnableProduct)
                .WithMany(e => e.ContractAssets)
                .HasForeignKey(e => e.PawnableProductId)
                .HasConstraintName("Fk_ContractAsset_PawnableProduct");

                en.HasOne(e => e.Warehouse)
                .WithOne(e => e.ContractAsset)
                .HasForeignKey<ContractAsset>(e => e.WarehouseId)
                .HasConstraintName("FK_ContractAsset_Warehouse");
            });
            //Kyc
            modelBuilder.Entity<Kyc>(en =>
            {
                en.ToTable("Kyc");
                en.HasKey(e => e.KycId);
            });
            //DependentPeople
            modelBuilder.Entity<DependentPeople>(en =>
            {
                en.ToTable("DependentPeople");
                en.HasKey(e => e.DependentPeopleId);
            });
            //Job
            modelBuilder.Entity<Job>(en =>
            {
                en.ToTable("Job");
                en.HasKey(e => e.JobId);
            });
            //CustomerRelativeShip
            modelBuilder.Entity<CustomerRelativeRelationship>(en =>
            {
                en.ToTable("CustomerRelativeRelationship");
                en.HasKey(e => e.CustomerRelativeRelationshipId);
            });
            #region Contract
            modelBuilder.Entity<Contract>(en =>
            {
                en.ToTable("Contract");
                en.HasKey(e => e.ContractId);
                //relative
                en.HasOne(e => e.Package)
                .WithMany(e => e.Contracts)
                .HasForeignKey(e => e.PackageId)
                .HasConstraintName("Fk_Contract_Package");

                en.HasOne(e => e.Branch)
                .WithMany(e => e.Contracts)
                .HasForeignKey(e => e.BranchId)
                .HasConstraintName("Fk_Contract_Branch");

                en.HasOne(e => e.ContractAsset)
                .WithMany(e => e.Contracts)
                .HasForeignKey(e => e.ContractAssetId)
                .HasConstraintName("Fk_Contract_ContractAsset");

                en.HasOne(e => e.Customer)
                .WithMany(e => e.Contracts)
                .HasForeignKey(e => e.CustomerId)
                .HasConstraintName("Fk_Contract_Customer");
            });
#endregion
            #region DB Customer
            modelBuilder.Entity<Customer>(en =>
            {
                en.ToTable("Customer");
                en.HasKey(e => e.CustomerId);
                //Relative
                en.HasMany(e => e.DependentPeople)
                .WithOne(e => e.Customer)
                .HasForeignKey(e => e.CustomerId)
                .HasConstraintName("Fk_Customer_DependentPeople");

                en.HasMany(e => e.Jobs)
                .WithOne(e => e.Customer)
                .HasForeignKey(e => e.CustomerId)
                .HasConstraintName("Fk_Customer_Job");

                en.HasMany(e => e.CustomerRelativeRelationships)
                .WithOne(e => e.Customer)
                .HasForeignKey(e => e.CustomerId)
                .HasConstraintName("Fk_Customer_CustomerRelativeShip");

                en.HasOne(e => e.Kyc)
                .WithOne(e => e.Customer)
                .HasForeignKey<Customer>(e => e.KycId)
                .HasConstraintName("Fk_Customer_Kyc");
            
            });
            #endregion

        }

    }
}
