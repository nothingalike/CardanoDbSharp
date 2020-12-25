using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Mappings
{
    public class PoolRelayMap : EntityMap<PoolRelay>
    {
        public PoolRelayMap()
        {
            Map(p => p.UpdateId).ToColumn("update_id");
            Map(p => p.DnsName).ToColumn("dns_name");
            Map(p => p.DnsSrvName).ToColumn("dns_srv_name");
        }
    }
}
