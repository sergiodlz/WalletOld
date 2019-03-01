using System;

namespace Wallet.DATA.Entities
{
    public class Account : EntityBase<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid TypeId { get; set; }

        public virtual AccountType Type { get; set; }
    }
}
