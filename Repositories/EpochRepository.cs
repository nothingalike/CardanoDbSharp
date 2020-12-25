using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IEpochRepository : IRepository<Epoch>
    {
    }
    public class EpochRepository : Repository<Epoch>, IEpochRepository
    {
        public EpochRepository(IConfiguration configuration)
            : base(configuration, TableNames.Epoch) { }
    }
}
