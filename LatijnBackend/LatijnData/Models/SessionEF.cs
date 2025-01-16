using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LatijnData.Models
{
    public class SessionEF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; }
        //public required string Code { get; set; }
        public DocentEF? Docent { get; set; }
        public int? DocentId { get; set; }

        public List<ToetsEF> ToetsenEF { get; set; } = new List<ToetsEF>();
    }
}
