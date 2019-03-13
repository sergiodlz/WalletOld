using System;

namespace Wallet.DATA.Entities
{
    public class SubCategory : EntityBase
    {
        public string Name { get; set; }

        public Guid CategoryId { get; set; }
    }
}