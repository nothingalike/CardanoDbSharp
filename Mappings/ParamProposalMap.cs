using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Mappings
{
    public class ParamProposalMap : EntityMap<ParamProposal>
    {
        public ParamProposalMap()
        {
            Map(p => p.EpochNo).ToColumn("epoch_no");
            Map(p => p.MinFeeA).ToColumn("min_fee_a");
            Map(p => p.MinFeeB).ToColumn("min_fee_b");
            Map(p => p.MaxBlockSize).ToColumn("max_block_size");
            Map(p => p.MaxTxSize).ToColumn("max_tx_size");
            Map(p => p.MaxBhSize).ToColumn("max_bh_size");
            Map(p => p.KeyDeposit).ToColumn("key_deposit");
            Map(p => p.PoolDeposit).ToColumn("pool_deposit");
            Map(p => p.MaxEpoch).ToColumn("max_epoch");
            Map(p => p.OptimalPoolCount).ToColumn("optimal_pool_count");
            Map(p => p.MonetaryExpandRate).ToColumn("monetary_expand_rate");
            Map(p => p.TreasuryGrowthRate).ToColumn("treasury_growth_rate");
            Map(p => p.ProtocolMajor).ToColumn("protocol_major");
            Map(p => p.ProtocolMinor).ToColumn("protocol_minor");
            Map(p => p.MinUtxoValue).ToColumn("min_utxo_value");
            Map(p => p.MinPoolCost).ToColumn("min_pool_cost");
            Map(p => p.RegisteredTxId).ToColumn("registered_tx_id");
        }
    }
}
