using Microsoft.EntityFrameworkCore;

namespace Wallet.DATA.Configurations.Core
{
    public interface IEntityTypeMap
    {
        void Map(ModelBuilder builder);
    }
}