using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatijnLogic.Types
{
    public class Vervoeging
    {
        public int VervoegingID { get; set; }
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
