using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatijnLogic.Interfaces
{
    public interface IRandomNumbers
    {
        public List<int> GenerateNRandomNumbers(int totalAmount, int n);
    }
}
