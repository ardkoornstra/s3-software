using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LatijnData.Models
{
    public class UitgangEF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UitgangID { get; set; }
        public int Conjugatie { get; set; }
        public required string Vorm { get; set; }
        public required string Modus { get; set; }
        public required string Tempus { get; set; }
        public required string Genus { get; set; }
        public required string Persoon { get; set; }
        public required string Getal { get; set; }
        public required string Stam { get; set; }
    }
}
