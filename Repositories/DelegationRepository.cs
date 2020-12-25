using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IDelegationRepository : IRepository<Delegation>
    {
    }
    public class DelegationRepository : Repository<Delegation>, IDelegationRepository
    {
        public DelegationRepository(IConfiguration configuration)
            : base(configuration, TableNames.Delegation) { }
    }
}
