using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IStakeDeregistrationRepository : IRepository<StakeDeregistration>
    {
    }
    public class StakeDeregistrationRepository : Repository<StakeDeregistration>, IStakeDeregistrationRepository
    {
        public StakeDeregistrationRepository(IConfiguration configuration)
            : base(configuration, TableNames.StakeDeregistration) { }
    }
}
