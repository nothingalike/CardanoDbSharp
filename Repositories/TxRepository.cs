using System;
using System.Threading.Tasks;
using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;

namespace CardanoDbSharp.Repositories
{
    public interface ITxRepository: IRepository<Tx>
    {
        Task<Tx> GetByHashStrAsync(string hashStr);
    }
    public class TxRepository : Repository<Tx>, ITxRepository
    {
        public TxRepository(IConfiguration configuration) 
            : base(configuration, TableNames.Tx) { }

        public async Task<Tx> GetByHashStrAsync(string hashStr)
        {
            using (var conn = GetConnection)
            {
                try
                {
                    conn.Open();
                    return await conn.QueryFirstOrDefaultAsync<Tx>(
                        $"select * from {_tableName} where encode(hash, 'hex') = @HashStr",
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