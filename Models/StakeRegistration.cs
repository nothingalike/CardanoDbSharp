﻿using System;
using System.Collections.Generic;

#nullable disable

namespace CardanoDbSharp.Models
{
    public partial class StakeRegistration
    {
        public long Id { get; set; }
        public long AddrId { get; set; }
        public int CertIndex { get; set; }
        public long TxId { get; set; }

        public virtual StakeAddress Addr { get; set; }
        public virtual Tx Tx { get; set; }
    }
}
