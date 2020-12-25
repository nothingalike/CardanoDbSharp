using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Mappings
{
    public class MaTxOutMap : EntityMap<MaTxOut>
    {
        public MaTxOutMap()
        {
            Map(p => p.TxOutId).ToColumn("tx_out_id");
        }
    }
}
