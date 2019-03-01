using System;
using System.Collections.Generic;

namespace Wallet.DATA.Entities
{
    public class Category : EntityBase<Guid>
    {
        public string Name { get; set; }

        public IEnumerable<SubCategory> SubCategories { get; set; }
    }
}
