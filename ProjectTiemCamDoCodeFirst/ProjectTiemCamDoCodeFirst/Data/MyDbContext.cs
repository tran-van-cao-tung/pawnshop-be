using Microsoft.EntityFrameworkCore;
using ProjectTiemCamDoCodeFirst.Model;

namespace ProjectTiemCamDoCodeFirst.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        #region DbSet
        public DbSet<Role> roles { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<AssetColor> AssetColor { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractAsset> ContractAssets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerRelativeRelationship> customerRelativeRelationships { get; set; }
        public DbSet<DependentPeopel> DependentPeopel { get; set; }
        public DbSet<InterestDiary> InterestDiary { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<KYC> KYC { get; set; }
        public DbSet<Ledger> Ledger { get; set; }
        public DbSet<Liquidation> Liquidation { get; set; }
        public DbSet<Package> packages { get; set; }
        public DbSet<pawnableProduct> pawnableProduct { get; set; }
        public DbSet<WareHouse> warehouse { get; set; }
        #endregion DbSet

        #region OnModel
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //User
            modelBuilder.Entity<User>(en =>
            {

                en.HasOne(e => e.role)
                .WithMany(e => e.users)
                .HasForeignKey(e => e.RoleId)
                .HasConstraintName("FK_User_Role");

                en.HasOne(e => e.branch)
                .WithMany(e => e.users)
                .HasForeignKey(e => e.branchId)
                .HasConstraintName("FK_User_Branch");
            });

            //Ledger
            modelBuilder.Entity<Ledger>(en =>
            {
                en.HasOne(e => e.branch)
                .WithMany(e => e.ledger)
                .HasForeignKey(e => e.branchId)
                .HasConstraintName("FK_Ledger_Branch");

            });

            //InterestDiary
            modelBuilder.Entity<InterestDiary>(en =>
            {
                en.HasOne(e => e.contract)
                .WithMany(e => e.interestDiaries)
                .HasForeignKey(e => e.contractId)
                .HasConstraintName("FK_InterestDiary_Contract");
            });

            //Liquidation
            modelBuilder.Entity<Liquidation>(en =>
            {
                en.HasOne(e => e.contract)
                .WithOne(e => e.liquidations)
                .HasForeignKey<Liquidation>(e => e.contractId)
                .HasConstraintName("FK_Liquidation_Contract");
            });

            //Contract
            modelBuilder.Entity<Contract>(en =>
            {
                en.HasOne(e => e.branch)
                .WithMany(e => e.contract)
                .HasForeignKey(e => e.branchId)
                .HasConstraintName("FK_Contract_Branch");

                en.HasOne(e => e.customer)
                .WithMany(e => e.contracts)
                .HasForeignKey(e => e.customerId)
                .HasConstraintName("FK_Contract_Customer");

                en.HasOne(e => e.package)
                .WithMany(e => e.contracts)
                .HasForeignKey(e => e.packageId)
                .HasConstraintName("FK_Contract_Package");

            });

            //Customer
            modelBuilder.Entity<Job>(en => {
                en.HasOne(e => e.customer).
                WithMany(e => e.job)
                .HasForeignKey(p => p.)
                });

            modelBuilder.Entity<Customer>(en =>
            {
                en.HasOne<Job>()

                en.HasMany(e => e.job)
                .WithOne(p=> p.customer)
                .HasForeignKey(p => p.)
                .HasConstraintName("FK_Customer_Job");

                en.HasMany(e => e.dependentPeopel)
                .WithOne(e => e.customer)
                .HasForeignKey(e => e.customer.dependentPeopelId)
                .HasConstraintName("FK_Customer_Dependent");

                en.HasMany(e => e.customerRelativeRelationshipx)
                .WithOne(e => e.customer)
                .HasForeignKey(e => e.customer.customerRelativeId)
                .HasConstraintName("FK_Customer_CustomerRelativeShip");

                en.HasOne(e => e.kyc)
                .WithOne(e => e.customer)
                .HasForeignKey<Customer>(e => e.kycId)
                .HasConstraintName("FK_Customer_Kyc");
            });

            //Contract Asset
            modelBuilder.Entity<ContractAsset>(en =>
            {
                en.HasOne(e => e.pawnableProduct)
                .WithMany(e => e.contractAssets)
                .HasForeignKey(e => e.contractId)
                .HasConstraintName("FK_ContractAsset_PawnableProduct");

                en.HasOne(e => e.assetColor)
                .WithMany(e => e.contractAssets)
                .HasForeignKey(e => e.assetColorId)
                .HasConstraintName("FK_ContractAsset_AssetColor");

                en.HasOne(e => e.wareHouse)
                .WithOne(e => e.ContractAsset)
                .HasForeignKey<ContractAsset>(e => e.contractAssetId)
                .HasConstraintName("FK_ContractAsset_WareHouse");

                en.HasMany(e => e.contract)
                .WithOne(e => e.contractAsset)
                .HasForeignKey(e => e.contractId)
                .HasConstraintName("FK_ContractAsset_Contract");

            });
        }
        #endregion OnModel
    }
}
