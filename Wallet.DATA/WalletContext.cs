using Microsoft.EntityFrameworkCore;
using Wallet.DATA.Configurations;
using Wallet.DATA.Entities;

namespace Wallet.DATA
{
    public class WalletContext : DbContext
    {
        public WalletContext(DbContextOptions<WalletContext> options) : base(options)
        {
        }

        public DbSet<AccountType> AccountTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AccountTypeConfiguration("AccountType", "AccountTypeId").Map(modelBuilder);
        }
    }
}