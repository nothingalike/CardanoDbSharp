using CardanoDbSharp.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Models
{
    [Table(TableNames.PoolMetaDatum)]
    public partial class PoolMetaDatum
    {
        public PoolMetaDatum()
        {
            PoolUpdates = new HashSet<PoolUpdate>();
        }

        public long Id { get; set; }
        public string Url { get; set; }
        public byte[] Hash { get; set; }
        public long RegisteredTxId { get; set; }

        public virtual Tx RegisteredTx { get; set; }
        public virtual ICollection<PoolUpdate> PoolUpdates { get; set; }
    }
}
