using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IRewardRepository : IRepository<Reward>
    {
    }
    public class RewardRepository : Repository<Reward>, IRewardRepository
    {
        public RewardRepository(IConfiguration configuration)
            : base(configuration, TableNames.Reward) { }
    }
}
