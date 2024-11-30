using LatijnLogic.Interfaces;
using LatijnLogic.Types;

namespace LatijnLogic.Utility
{
    public class RandomNumbers : IRandomNumbers
    {
        public RandomNumbers() { }

        public List<int> GenerateNRandomNumbers(int totalAmount, int n)
        {
            List<int> randomNumbers = new List<int>();
            int newNumber;
            var random = new Random();
            for (int i = 0; i < n; i++)
            {
                do
                {
                    newNumber = random.Next(totalAmount) + 1;
                } while (randomNumbers.Contains(newNumber));
                randomNumbers.Add(newNumber);
            }
            return randomNumbers;
        }

        private Random rng = new Random();

        public List<Vervoeging> ShuffleVervoegingen(List<Vervoeging> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Vervoeging value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }
    }
}
