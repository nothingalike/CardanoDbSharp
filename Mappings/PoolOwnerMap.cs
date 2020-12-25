using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Mappings
{
    public class PoolOwnerMap : EntityMap<PoolOwner>
    {
        public PoolOwnerMap()
        {
            Map(p => p.PoolHashId).ToColumn("pool_hash_id");
            Map(p => p.RegisteredTxId).ToColumn("registered_tx_id");
        }
    }
}
