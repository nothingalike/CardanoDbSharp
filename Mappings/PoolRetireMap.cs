using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Mappings
{
    public class PoolRetireMap : EntityMap<PoolRetire>
    {
        public PoolRetireMap()
        {
            Map(p => p.HashId).ToColumn("hash_id");
            Map(p => p.CertIndex).ToColumn("cert_index");
            Map(p => p.AnnouncedTxId).ToColumn("announced_tx_id");
            Map(p => p.RetiringEpoch).ToColumn("retiring_epoch");
        }
    }
}
