using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EArsivPortal.Data
{
    [Table("Document")]
    public class Document
    {
        public int DocumentId { get; set; }
        [Required]
        public string DocumentName { get; set; }
    }
}
