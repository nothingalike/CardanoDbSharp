using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface ITxOutRepository: IRepository<TxOut>
    {
    }
    public class TxOutRepository: Repository<TxOut>, ITxOutRepository
    {
        public TxOutRepository(IConfiguration configuration) 
            : base(configuration, TableNames.TxOut) { }
    }
}
