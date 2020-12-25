using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{   
    public interface IUtxoViewRepository: IRepository<UtxoView>
    {
    }
    public class UtxoViewRepository: Repository<UtxoView>, IUtxoViewRepository
    {
        public UtxoViewRepository(IConfiguration configuration) 
            : base(configuration, TableNames.UtxoView) { }
    }
}
