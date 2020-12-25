using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface ITxMetadatumRepository: IRepository<TxMetadatum>
    {
    }
    public class TxMetadatumRepository: Repository<TxMetadatum>, ITxMetadatumRepository
    {
        public TxMetadatumRepository(IConfiguration configuration) 
            : base(configuration, TableNames.TxMetadatum) { }
    }
}
