﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LatijnData.Models
{
    public class ToetsEF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; }
        public required int AantalVragen { get; set; }
        public required int AantalGoed { get; set; }
        public required int SessionId { get; set; }

        public required List<VervoegingEF> VervoegingenEF { get; set; }
    }
}
