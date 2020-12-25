using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardanoDbSharp.Mappings
{
    public class MaTxMintMap : EntityMap<MaTxMint>
    {
        public MaTxMintMap()
        {
            Map(p => p.TxId).ToColumn("tx_id");
        }
    }
}
