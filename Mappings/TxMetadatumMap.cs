using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Mappings
{
    public class TxMetadatumMap : EntityMap<TxMetadatum>
    {
        public TxMetadatumMap()
        {
            Map(p => p.TxId).ToColumn("tx_id");
        }
    }
}
