using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface ITreasuryRepository : IRepository<Treasury>
    {
    }
    public class TreasuryRepository : Repository<Treasury>, ITreasuryRepository
    {
        public TreasuryRepository(IConfiguration configuration)
            : base(configuration, TableNames.Treasury) { }
    }
}
