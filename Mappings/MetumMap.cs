using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Mappings
{
    public class MetumMap : EntityMap<Metum>
    {
        public MetumMap()
        {
            Map(p => p.StartTime).ToColumn("start_time");
            Map(p => p.NetworkName).ToColumn("network_name");
        }
    }
}
