using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IEpochParamRepository : IRepository<EpochParam>
    {
    }
    public class EpochParamRepository : Repository<EpochParam>, IEpochParamRepository
    {
        public EpochParamRepository(IConfiguration configuration)
            : base(configuration, TableNames.EpochParam) { }
    }
}
