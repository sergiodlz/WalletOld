using System;

namespace Wallet.DATA.Entities
{
    public class SubCategory : EntityBase<Guid>
    {
        public string Name { get; set; }

        public Guid CategoryId { get; set; }
    }
}