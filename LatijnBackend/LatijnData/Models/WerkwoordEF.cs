﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LatijnData.Models
{
    public class WerkwoordEF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WoordID { get; set; }
        public required string Infinitivus { get; set; }
        public required string Praesens { get; set; }
        public required string Perfectum { get; set; }
        public required string Supinum { get; set; }
        public required int Conjugatie { get; set; }
        public required string Betekenis { get; set; }
    }
}
