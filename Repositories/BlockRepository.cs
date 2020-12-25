using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardanoDbSharp.Repositories
{
    public interface IBlockRepository: IRepository<Block>
    {
    }

    public class BlockRepository : Repository<Block>, IBlockRepository
    {
        public BlockRepository(IConfiguration configuration) 
            : base(configuration, TableNames.Block) { }
    }
}
