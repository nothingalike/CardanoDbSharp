using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Models
{
    [Table("public.pool_owner")]
    public partial class PoolOwner
    {
        public long Id { get; set; }
        public byte[] Hash { get; set; }
        public long PoolHashId { get; set; }
        public long RegisteredTxId { get; set; }

        public virtual PoolHash PoolHash { get; set; }
        public virtual Tx RegisteredTx { get; set; }
    }
}
