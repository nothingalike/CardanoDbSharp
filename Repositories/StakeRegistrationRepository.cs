using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IStakeRegistrationRepository : IRepository<StakeRegistration>
    {
    }
    public class StakeRegistrationRepository : Repository<StakeRegistration>, IStakeRegistrationRepository
    {
        public StakeRegistrationRepository(IConfiguration configuration)
            : base(configuration, TableNames.StakeRegistration) { }
    }
}
