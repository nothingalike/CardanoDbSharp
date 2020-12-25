using CardanoDbSharp.Common;
using CardanoDbSharp.Models;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Mappings
{
    public class SchemaVersionMap : EntityMap<SchemaVersion>
    {
        public SchemaVersionMap()
        {
            Map(p => p.StageOne).ToColumn("stage_one");
            Map(p => p.StageTwo).ToColumn("stage_two");
            Map(p => p.StageThree).ToColumn("stage_three");
        }
    }
}
