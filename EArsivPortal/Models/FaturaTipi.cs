using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourNamespace.Models
{
    public class FaturaTipi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FaturaTipiID { get; set; }

        [StringLength(50)]
        [Required]
        public string Tip { get; set; }

        public virtual ICollection<Belge> Belgeler { get; set; }
    }
}
