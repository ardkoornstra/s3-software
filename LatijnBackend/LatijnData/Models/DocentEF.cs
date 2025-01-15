using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace LatijnData.Models
{
    public class DocentEF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; }
        public required string Name { get; set; }

        public List<SessionEF> Sessions { get; set; } = new List<SessionEF>();
    }
}
