using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardanoDbSharp.Common
{
    public static class TableNames
    {
        public const string Block = "public.block";
        public const string Delegation = "public.delegation";
        public const string Epoch = "public.epoch";
        public const string EpochParam = "public.epoch_param";
        public const string EpochStake = "public.epoch_stake";
        public const string MaTxMint = "public.ma_tx_mint";
        public const string MaTxOut = "public.ma_tx_out";
        public const string Metum = "public.meta";
        public const string ParamProposal = "public.param_proposal";
        public const string PoolHash = "public.pool_hash";
        public const string PoolMetaDatum = "public.pool_meta_data";
        public const string PoolOwner = "public.pool_owner";
        public const string PoolRelay = "public.pool_relay";
        public const string PoolRetire = "public.pool_retire";
        public const string PoolUpdate = "public.pool_update";
        public const string Reserve = "public.reserve";
        public const string Reward = "public.reward";
        public const string SchemaVersion = "public.schema_version";
        public const string SlotLeader = "public.slot_leader";
        public const string StakeAddress = "public.stake_address";
        public const string StakeDeregistration = "public.stake_deregistration";
        public const string StakeRegistration = "public.stake_registration";
        public const string Treasury = "public.treasury";
        public const string Tx = "public.tx";
        public const string TxIn = "public.tx_in";
        public const string TxMetadatum = "public.tx_metadata";
        public const string TxOut = "public.tx_out";
        public const string UtxoView = "public.utxo_view";
        public const string Withdrawal = "public.withdrawal";
    }
}
