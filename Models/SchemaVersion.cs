﻿using System;
using System.Collections.Generic;

#nullable disable

namespace CardanoDbSharp.Models
{
    public partial class SchemaVersion
    {
        public long Id { get; set; }
        public long StageOne { get; set; }
        public long StageTwo { get; set; }
        public long StageThree { get; set; }
    }
}
