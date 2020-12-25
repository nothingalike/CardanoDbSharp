using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Mappings
{
    public class StakeAddressMap : EntityMap<StakeAddress>
    {
        public StakeAddressMap()
        {
            Map(p => p.HashRaw).ToColumn("hash_raw");
            Map(p => p.RegisteredTxId).ToColumn("registered_tx_id");
        }
    }
}
