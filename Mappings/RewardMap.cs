using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Mappings
{
    public class RewardMap : EntityMap<Reward>
    {
        public RewardMap()
        {
            Map(p => p.AddrId).ToColumn("addr_id");
            Map(p => p.PoolId).ToColumn("pool_id");
            Map(p => p.EpochNo).ToColumn("epoch_no");
            Map(p => p.BlockId).ToColumn("block_id");
        }
    }
}
