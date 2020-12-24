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
            using(var conn = GetConnection)
            {
                try
                {
                    conn.Open();
                    return await conn.GetAsync<Block>(id);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }
            }
        }
    }
}
