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
        public string Tip { get; set; }

        public virtual ICollection<Belgeler> Belge { get; set; }
    }
}
