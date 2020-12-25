using CardanoDbSharp.Mappings;
using CardanoDbSharp.Repositories;
using Dapper.FluentMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardanoDbSharp
{
    public interface ICardanoDbApi
    {
        IBlockRepository BlockRepo { get; }
        IDelegationRepository DelegationRepo { get; }
        IEpochParamRepository EpochParamRepo { get; }
        IEpochRepository EpochRepo { get; }
        IEpochStakeRepository EpochStakeRepo { get; }
        IMaTxMintRepository MaTxMintRepo { get; }
        IMaTxOutRepository MaTxOutRepo { get; }
        IMetumRepository MetumRepo { get; }
        IParamProposalRepository ParamProposalRepo { get; }
        IPoolHashRepository PoolHashRepo { get; }
        IPoolMetaDatumRepository PoolMetaDatumRepo { get; }
        IPoolOwnerRepository PoolOwnerRepo { get; }
        IPoolRelayRepository PoolRelayRepo { get; }
        IPoolRetireRepository PoolRetireRepo { get; }
        IPoolUpdateRepository PoolUpdateRepo { get; }
        IReserveRepository ReserveRepo { get; }
        IRewardRepository RewardRepo { get; }
        ISchemaVersionRepository SchemaVersionRepo { get; }
        ISlotLeaderRepository SlotLeaderRepo { get; }
        IStakeAddressRepository StakeAddressRepo { get; }
        IStakeRegistrationRepository StakeRegistrationRepo { get; }
        IStakeDeregistrationRepository StakeDeregistrationRepo { get; }
        ITreasuryRepository TreasuryRepo { get; }
        ITxInRepository TxInRepo { get; }
        ITxOutRepository TxOutRepo { get; }
        ITxMetadatumRepository TxMetadatumRepo { get; }
        IUtxoViewRepository UtxoViewRepo { get; }
        IWithdrawalRepository WithdrawalRepo { get; }
        ITxRepository TxRepo { get; }
    }

    public class CardanoDbApi: ICardanoDbApi
    {
        public CardanoDbApi(
            IBlockRepository blockRepo,
            ITxRepository txRepo,
            IDelegationRepository delegationRepo,
            IEpochParamRepository epochParamRepo,
            IEpochRepository epochRepo,
            IEpochStakeRepository epochStakeRepo,
            IMaTxMintRepository maTxMintRepo,
            IMaTxOutRepository maTxOutRepo,
            IMetumRepository metumRepo,
            IParamProposalRepository paramProposalRepo,
            IPoolHashRepository poolHashRepo,
            IPoolMetaDatumRepository poolMetaDatumRepo,
            IPoolOwnerRepository poolOwnerRepo,
            IPoolRelayRepository poolRelayRepo,
            IPoolRetireRepository poolRetireRepo,
            IPoolUpdateRepository poolUpdateRepo,
            IReserveRepository reserveRepo,
            IRewardRepository rewardRepo,
            ISchemaVersionRepository schemaVersionRepo,
            ISlotLeaderRepository slotLeaderRepo,
            IStakeAddressRepository stakeAddressRepo,
            IStakeRegistrationRepository stakeRegistrationRepo,
            IStakeDeregistrationRepository stakeDeregistrationRepo,
            ITreasuryRepository treasuryRepo,
            ITxInRepository txInRepo,
            ITxOutRepository txOutRepo,
            ITxMetadatumRepository txMetadatumRepo,
            IUtxoViewRepository utxoViewRepo,
            IWithdrawalRepository withdrawalRepo)
        {
            FluentMapper.Initialize(c =>
            {
                c.AddMap(new BlockMap());
                c.AddMap(new DelegationMap());
                c.AddMap(new EpochMap());
                c.AddMap(new EpochParamMap());
                c.AddMap(new EpochStakeMap());
                c.AddMap(new MaTxMintMap());
                c.AddMap(new MaTxOutMap());
                c.AddMap(new MetumMap());
                c.AddMap(new ParamProposalMap());
                c.AddMap(new PoolHashMap());
                c.AddMap(new PoolMetaDatumMap());
                c.AddMap(new PoolOwnerMap());
                c.AddMap(new PoolRelayMap());
                c.AddMap(new PoolRetireMap());
                c.AddMap(new PoolUpdateMap());
                c.AddMap(new ReserveMap());
                c.AddMap(new RewardMap());
                c.AddMap(new SchemaVersionMap());
                c.AddMap(new SlotLeaderMap());
                c.AddMap(new StakeAddressMap());
                c.AddMap(new StakeRegistrationMap());
                c.AddMap(new StakeDeregistrationMap());
                c.AddMap(new TreasuryMap());
                c.AddMap(new TxMap());
                c.AddMap(new TxInMap());
                c.AddMap(new TxOutMap());
                c.AddMap(new TxMetadatumMap());
                c.AddMap(new UtxoViewMap());
                c.AddMap(new WithdrawalMap());
            });

            BlockRepo = blockRepo;
            DelegationRepo = delegationRepo;
            EpochParamRepo = epochParamRepo;
            EpochRepo = epochRepo;
            EpochStakeRepo = epochStakeRepo;
            MaTxMintRepo = maTxMintRepo;
            MaTxOutRepo = maTxOutRepo;
            MetumRepo = metumRepo;
            ParamProposalRepo = paramProposalRepo;
            PoolHashRepo = poolHashRepo;
            PoolMetaDatumRepo = poolMetaDatumRepo;
            PoolOwnerRepo = poolOwnerRepo;
            PoolRelayRepo = poolRelayRepo;
            PoolRetireRepo = poolRetireRepo;
            PoolUpdateRepo = poolUpdateRepo;
            ReserveRepo = reserveRepo;
            RewardRepo = rewardRepo;
            SchemaVersionRepo = schemaVersionRepo;
            SlotLeaderRepo = slotLeaderRepo;
            StakeAddressRepo = stakeAddressRepo;
            StakeRegistrationRepo = stakeRegistrationRepo;
            StakeDeregistrationRepo = stakeDeregistrationRepo;
            TreasuryRepo = treasuryRepo;
            TxInRepo = txInRepo;
            TxOutRepo = txOutRepo;
            TxMetadatumRepo = txMetadatumRepo;
            UtxoViewRepo = utxoViewRepo;
            WithdrawalRepo = withdrawalRepo;
            TxRepo = txRepo;
        }

        public IBlockRepository BlockRepo { get; private set; }
        public ITxRepository TxRepo { get; private set; }

        public IDelegationRepository DelegationRepo { get; private set; }

        public IEpochParamRepository EpochParamRepo { get; private set; }

        public IEpochRepository EpochRepo { get; private set; }

        public IEpochStakeRepository EpochStakeRepo { get; private set; }

        public IMaTxMintRepository MaTxMintRepo { get; private set; }

        public IMaTxOutRepository MaTxOutRepo { get; private set; }

        public IMetumRepository MetumRepo { get; private set; }

        public IParamProposalRepository ParamProposalRepo { get; private set; }

        public IPoolHashRepository PoolHashRepo { get; private set; }

        public IPoolMetaDatumRepository PoolMetaDatumRepo { get; private set; }

        public IPoolOwnerRepository PoolOwnerRepo { get; private set; }

        public IPoolRelayRepository PoolRelayRepo { get; private set; }

        public IPoolRetireRepository PoolRetireRepo { get; private set; }

        public IPoolUpdateRepository PoolUpdateRepo { get; private set; }

        public IReserveRepository ReserveRepo { get; private set; }

        public IRewardRepository RewardRepo { get; private set; }

        public ISchemaVersionRepository SchemaVersionRepo { get; private set; }

        public ISlotLeaderRepository SlotLeaderRepo { get; private set; }

        public IStakeAddressRepository StakeAddressRepo { get; private set; }

        public IStakeRegistrationRepository StakeRegistrationRepo { get; private set; }

        public IStakeDeregistrationRepository StakeDeregistrationRepo { get; private set; }

        public ITreasuryRepository TreasuryRepo { get; private set; }

        public ITxInRepository TxInRepo { get; private set; }

        public ITxOutRepository TxOutRepo { get; private set; }

        public ITxMetadatumRepository TxMetadatumRepo { get; private set; }

        public IUtxoViewRepository UtxoViewRepo { get; private set; }

        public IWithdrawalRepository WithdrawalRepo { get; private set; }
    }
}
