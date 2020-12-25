using CardanoDbSharp.Common;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardanoDbSharp.Repositories
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetPagedListAsync(int pageSize, int pageNumber, TableSort sort = TableSort.Asc);
    }

    public abstract class Repository<T>: IRepository<T>
    {
        protected readonly IConfiguration _configuration;
        protected readonly string _tableName;

        public Repository(IConfiguration configuration, string tableName)
        {
            _configuration = configuration;
            _tableName = tableName;
        }

        protected IDbConnection GetConnection => new NpgsqlConnection(_configuration.GetConnectionString("CardanoDbSync"));

        public virtual async Task<T> GetByIdAsync(int id)
        {
            using (var conn = GetConnection)
            {
                try
                {
                    conn.Open();
                    return await conn.QuerySingleOrDefaultAsync<T>(
                        $"select * from {_tableName} where id = @Id",
                        new { 
                            TableName = _tableName,
                            Id = id 
                        });
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }
            }
        }

        public async Task<IEnumerable<T>> GetPagedListAsync(int pageSize, int pageNumber, TableSort sort = TableSort.Asc)
        {
            using (var conn = GetConnection)
            {
                try
                {
                    conn.Open();
                    return await conn.QueryAsync<T>(
                        $@"select * from {_tableName} 
                            order by id {sort}
                            limit @PageSize
                            offset @PageNumber",
                        new
                        {
                            TableName = _tableName,
                            Sort = sort.ToString(),
                            PageSize = pageSize,
                            PageNumber = pageSize * pageNumber
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
