using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;

namespace CardanoDbSharp.Mappings
{
    public class BlockMap: EntityMap<Block>
    {
        public BlockMap()
        {
            Map(p => p.EpochNo).ToColumn("epoch_no");
            Map(p => p.SlotNo).ToColumn("slot_no");
            Map(p => p.EpochSlotNo).ToColumn("epoch_slot_no");
            Map(p => p.BlockNo).ToColumn("block_no");
            Map(p => p.PreviousId).ToColumn("previous_id");
            Map(p => p.SlotLeaderId).ToColumn("slot_leader_id");
            Map(p => p.TxCount).ToColumn("tx_count");
            Map(p => p.ProtoMajor).ToColumn("proto_major");
            Map(p => p.ProtoMinor).ToColumn("proto_minor");
            Map(p => p.MerkelRoot).ToColumn("merkel_root");
            Map(p => p.VrfKey).ToColumn("vrf_key");
            Map(p => p.OpCert).ToColumn("op_cert");
        }
    }
}