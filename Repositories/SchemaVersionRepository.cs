using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Repositories
{
    public interface ISchemaVersionRepository : IRepository<SchemaVersion>
    {
    }
    public class SchemaVersionRepository : Repository<SchemaVersion>, ISchemaVersionRepository
    {
        public SchemaVersionRepository(IConfiguration configuration)
            : base(configuration, TableNames.SchemaVersion) { }
    }
}
