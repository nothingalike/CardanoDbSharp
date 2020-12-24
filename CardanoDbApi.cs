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
        ITxRepository TxRepo { get; }
    }

    public class CardanoDbApi: ICardanoDbApi
    {
        public CardanoDbApi(
            IBlockRepository blockRepository,
            ITxRepository txRepository)
        {
            FluentMapper.Initialize(c =>
            {
                c.AddMap(new BlockMap());
                c.AddMap(new TxMap());
            });

            BlockRepo = blockRepository;
            TxRepo = txRepository;
        }

        public IBlockRepository BlockRepo { get; private set; }
        public ITxRepository TxRepo { get; private set; }
    }
}
