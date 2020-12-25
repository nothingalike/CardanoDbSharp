using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardanoDbSharp.Mappings
{
    public class EpochStakeMap : EntityMap<EpochStake>
    {
        public EpochStakeMap()
        {
            Map(p => p.AddrId).ToColumn("addr_id");
            Map(p => p.PoolId).ToColumn("pool_id");
            Map(p => p.EpochNo).ToColumn("epoch_no");
            Map(p => p.BlockId).ToColumn("block_id");
        }
    }
}
