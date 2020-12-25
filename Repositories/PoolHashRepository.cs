using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IPoolHashRepository : IRepository<PoolHash>
    {
    }
    public class PoolHashRepository : Repository<PoolHash>, IPoolHashRepository
    {
        public PoolHashRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolHash) { }
    }
}
