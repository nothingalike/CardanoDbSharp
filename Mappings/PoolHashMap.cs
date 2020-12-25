using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Mappings
{
    public class PoolHashMap : EntityMap<PoolHash>
    {
        public PoolHashMap()
        {
            Map(p => p.HashRaw).ToColumn("hash_raw");
        }
    }
}
