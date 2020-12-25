using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface ITxInRepository : IRepository<TxIn>
    {
    }
    public class TxInRepository : Repository<TxIn>, ITxInRepository
    {
        public TxInRepository(IConfiguration configuration)
            : base(configuration, TableNames.TxIn) { }
    }
}
