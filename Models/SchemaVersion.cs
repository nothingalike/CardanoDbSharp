using CardanoDbSharp.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Models
{
    [Table(TableNames.SchemaVersion)]
    public partial class SchemaVersion
    {
        public long Id { get; set; }
        public long StageOne { get; set; }
        public long StageTwo { get; set; }
        public long StageThree { get; set; }
    }
}
