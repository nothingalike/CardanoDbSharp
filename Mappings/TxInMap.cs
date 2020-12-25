using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Mappings
{
    public class TxInMap : EntityMap<TxIn>
    {
        public TxInMap()
        {
            Map(p => p.TxInId).ToColumn("tx_in_id");
            Map(p => p.TxOutId).ToColumn("tx_out_id");
            Map(p => p.TxOutIndex).ToColumn("tx_out_index");
        }
    }
}
