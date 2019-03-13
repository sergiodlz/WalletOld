using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Wallet.DATA.Configurations.Core;
using Wallet.DATA.Entities;

namespace Wallet.DATA.Configurations
{
    public class AccountTypeConfiguration : BaseEntityMap<AccountType>
    {
        public AccountTypeConfiguration(string TableName, string IdName) : base(TableName, IdName)
        {
        }

        protected override void InternalMap(EntityTypeBuilder<AccountType> builder)
        {
            builder
                .Property(x => x.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);

            builder
                .Property(x => x.Description)
                .IsUnicode()
                .HasMaxLength(1000);
        }
    }
}