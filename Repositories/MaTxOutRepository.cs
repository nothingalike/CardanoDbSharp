using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IMaTxOutRepository : IRepository<MaTxOut>
    {
    }
    public class MaTxOutRepository : Repository<MaTxOut>, IMaTxOutRepository
    {
        public MaTxOutRepository(IConfiguration configuration)
            : base(configuration, TableNames.MaTxOut) { }
    }
}
