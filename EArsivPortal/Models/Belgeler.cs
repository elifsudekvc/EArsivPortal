using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourNamespace.Models
{
    public class Belgeler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BelgeNumarasi { get; set; }

        public DateTime BelgeDuzenlemeTarihi { get; set; } = DateTime.Now;

        [StringLength(11)]
        public string VknTckn { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Soyad { get; set; }

        [StringLength(50)]
        public string Sehir { get; set; }

        [StringLength(100)]
        public string MahalleSemt { get; set; }

        [StringLength(255)]
        public string MalHizmet { get; set; }

        public int Miktar { get; set; }

        [Column(TypeName = "decimal(18,6)")]
        public decimal BirimFiyat { get; set; }

        [NotMapped]
        public decimal Tutar => Miktar * BirimFiyat;

        [StringLength(255)]
        public string FaturaTipi { get; set; }

    }
}
