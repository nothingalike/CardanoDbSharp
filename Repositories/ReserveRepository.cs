using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IReserveRepository : IRepository<Reserve>
    {
    }
    public class ReserveRepository : Repository<Reserve>, IReserveRepository
    {
        public ReserveRepository(IConfiguration configuration)
            : base(configuration, TableNames.Reserve) { }
    }
}
