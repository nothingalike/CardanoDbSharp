using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardanoDbSharp.Models
{

    [Table("public.block")]
    public class Block
    {
        [Key]
        public int Id { get; set; }
        public int EpochNo { get; set; }
        public int SlotNo { get; set; }
        public int EpochSlotNo { get; set; }
        public int BlockNo { get; set; }
        public int PreviousId { get; set; }
        public int SlotLeaderId { get; set; }
        public int Size { get; set; }
        public int TxCount { get; set; }
        public int ProtoMajor { get; set; }
        public int ProtoMinor { get; set; }
        //public string Hash { get; set; }
        //public string MerkelRoot { get; set; }
        public string VrfKey { get; set; }
        //public string OpCert { get; set; }
        //public DateTime Time { get; set; }
    }
}