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
    }

    public class CardanoDbApi: ICardanoDbApi
    {
        public CardanoDbApi(
            IBlockRepository blockRepository)
        {
            FluentMapper.Initialize(c =>
            {
                c.AddMap(new BlockMap());
            });

            BlockRepo = blockRepository;
        }

        public IBlockRepository BlockRepo { get; private set; }
    }
}
