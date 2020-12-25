using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IEpochStakeRepository : IRepository<EpochStake>
    {
    }
    public class EpochStakeRepository : Repository<EpochStake>, IEpochStakeRepository
    {
        public EpochStakeRepository(IConfiguration configuration)
            : base(configuration, TableNames.EpochStake) { }
    }
}
