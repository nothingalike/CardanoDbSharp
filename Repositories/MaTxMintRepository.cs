using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface IMaTxMintRepository : IRepository<MaTxMint>
    {
    }
    public class MaTxMintRepository : Repository<MaTxMint>, IMaTxMintRepository
    {
        public MaTxMintRepository(IConfiguration configuration)
            : base(configuration, TableNames.MaTxMint) { }
    }
}
