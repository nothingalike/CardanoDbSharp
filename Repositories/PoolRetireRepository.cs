using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IPoolRetireRepository : IRepository<PoolRetire>
    {
    }
    public class PoolRetireRepository : Repository<PoolRetire>, IPoolRetireRepository
    {
        public PoolRetireRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolRetire) { }
    }
}
