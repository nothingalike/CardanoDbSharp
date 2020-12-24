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
    public abstract class Repository
    {
        protected readonly IConfiguration _configuration;

        public Repository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected IDbConnection GetConnection => new NpgsqlConnection(_configuration.GetConnectionString("CardanoDbSync"));
    }
}
