using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoDbSharp.Models
{
    [Table("public.utxo_view")]
    public partial class UtxoView
    {
        public long? Id { get; set; }
        public long? TxId { get; set; }
        public short? Index { get; set; }
        public string Address { get; set; }
        public byte[] AddressRaw { get; set; }
        public byte[] PaymentCred { get; set; }
        public long? StakeAddressId { get; set; }
        public decimal? Value { get; set; }
    }
}
