using CardanoDbSharp.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardanoDbSharp.Repositories
{
    public interface IBlockRepository
    {
        Task<Block> GetByIdAsync(int id);
    }

    public class BlockRepository : Repository, IBlockRepository
    {
        public BlockRepository(IConfiguration configuration) : base(configuration) { }

        public async Task<Block> GetByIdAsync(int id)
        {
            using(var conn = Connection)
            {
                conn.Open();

                try
                {
                    return await conn.GetAsync<Block>(id);
                }catch(Exception e)
                {
                    var x = 0;
                    return null;
                }
            }
        }
    }
}
