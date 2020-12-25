using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IPoolUpdateRepository : IRepository<PoolUpdate>
    {
    }
    public class PoolUpdateRepository : Repository<PoolUpdate>, IPoolUpdateRepository
    {
        public PoolUpdateRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolUpdate) { }
    }
}
