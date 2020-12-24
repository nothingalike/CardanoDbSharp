﻿using System;
using System.Collections.Generic;

#nullable disable

namespace CardanoDbSharp.Models
{
    public partial class Reward
    {
        public long Id { get; set; }
        public long AddrId { get; set; }
        public decimal Amount { get; set; }
        public long EpochNo { get; set; }
        public long PoolId { get; set; }
        public long BlockId { get; set; }

        public virtual StakeAddress Addr { get; set; }
        public virtual Block Block { get; set; }
        public virtual PoolHash Pool { get; set; }
    }
}
