using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IPoolRelayRepository : IRepository<PoolRelay>
    {
    }
    public class PoolRelayRepository : Repository<PoolRelay>, IPoolRelayRepository
    {
        public PoolRelayRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolRelay) { }
    }
}
