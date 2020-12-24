using System;
using System.Threading.Tasks;
using CardanoDbSharp.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;

namespace CardanoDbSharp.Repositories
{
    public interface ITxRepository
    {
        Task<Tx> GetByIdAsync(int id);
        Task<Tx> GetByHashStrAsync(string hashStr);
    }
    public class TxRepository : Repository, ITxRepository
    {
        public TxRepository(IConfiguration configuration) : base(configuration) { }

        public async Task<Tx> GetByIdAsync(int id)
        {
            using(var conn = GetConnection)
            {
                try
                {
                    conn.Open();
                    return await conn.GetAsync<Tx>(id);
                }catch(Exception e)
                {
                    throw new Exception(e.Message, e);
                }
            }
        }

        public async Task<Tx> GetByHashStrAsync(string hashStr)
        {
            using (var conn = GetConnection)
            {
                try
                {
                    conn.Open();
                    return await conn.QueryFirstOrDefaultAsync<Tx>(
                        "select * from public.tx where encode(hash, 'hex') = @HashStr",
                        new
                        {
                            HashStr = hashStr
                        });
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }
            }
        }
    }
}