using System;

namespace Wallet.DATA.Entities
{
    public class RecordType : EntityBase<Guid>
    {
        public string Name { get; set; }
    }
}