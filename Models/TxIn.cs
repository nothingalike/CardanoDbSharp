using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Models
{
    [Table("public.tx_in")]
    public partial class TxIn
    {
        public long Id { get; set; }
        public long TxInId { get; set; }
        public long TxOutId { get; set; }
        public short TxOutIndex { get; set; }

        public virtual Tx TxInNavigation { get; set; }
        public virtual Tx TxOut { get; set; }
    }
}
