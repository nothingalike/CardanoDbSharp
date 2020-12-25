using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IPoolMetaDatumRepository : IRepository<PoolMetaDatum>
    {
    }
    public class PoolMetaDatumRepository : Repository<PoolMetaDatum>, IPoolMetaDatumRepository
    {
        public PoolMetaDatumRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolMetaDatum) { }
    }
}
