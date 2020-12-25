using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Mappings
{
    public class UtxoViewMap : EntityMap<UtxoView>
    {
        public UtxoViewMap()
        {
            Map(p => p.TxId).ToColumn("tx_id");
            Map(p => p.AddressRaw).ToColumn("address_raw");
            Map(p => p.PaymentCred).ToColumn("payment_cred");
            Map(p => p.StakeAddressId).ToColumn("stake_address_id");
        }
    }
}
