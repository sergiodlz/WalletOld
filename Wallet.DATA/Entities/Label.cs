using System;
using System.Collections.Generic;

namespace Wallet.DATA.Entities
{
    public class Label : EntityBase<Guid>
    {
        public string Name { get; set; }

        public virtual IEnumerable<Record> Records { get; set; }
    }
}