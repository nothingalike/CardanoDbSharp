using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;

namespace CardanoDbSharp.Mappings
{
    public class TxMap: EntityMap<Tx>
    {
        public TxMap()
        {
            Map(p => p.BlockId).ToColumn("block_id");
            Map(p => p.BlockIndex).ToColumn("block_index");
            Map(p => p.OutSum).ToColumn("out_sum");
            Map(p => p.InvalidBefore).ToColumn("invalid_before");
            Map(p => p.InvalidHereafter).ToColumn("invalid_hereafter");
        }
    }
}