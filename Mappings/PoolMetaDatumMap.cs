using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Mappings
{
    public class PoolMetaDatumMap : EntityMap<PoolMetaDatum>
    {
        public PoolMetaDatumMap()
        {
            Map(p => p.RegisteredTxId).ToColumn("registered_tx_id");
        }
    }
}
