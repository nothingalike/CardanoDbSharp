using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IMetumRepository : IRepository<Metum>
    {
    }
    public class MetumRepository : Repository<Metum>, IMetumRepository
    {
        public MetumRepository(IConfiguration configuration)
            : base(configuration, TableNames.Metum) { }
    }
}
