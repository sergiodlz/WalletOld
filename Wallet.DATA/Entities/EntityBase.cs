using System;

namespace Wallet.DATA.Entities
{
    public class EntityBase
    {
        public Guid Id { get; set; }

        public bool Enable { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ModificationDate { get; set; }
    }
}