using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Mappings
{
    public class SlotLeaderMap : EntityMap<SlotLeader>
    {
        public SlotLeaderMap()
        {
            Map(p => p.PoolHashId).ToColumn("pool_hash_id");
        }
    }
}
