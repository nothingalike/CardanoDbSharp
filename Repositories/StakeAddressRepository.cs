using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IStakeAddressRepository : IRepository<StakeAddress>
    {
    }
    public class StakeAddressRepository : Repository<StakeAddress>, IStakeAddressRepository
    {
        public StakeAddressRepository(IConfiguration configuration)
            : base(configuration, TableNames.StakeAddress) { }
    }
}
