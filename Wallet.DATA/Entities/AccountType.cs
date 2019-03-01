using System;

namespace Wallet.DATA.Entities
{
    public class AccountType : EntityBase<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}