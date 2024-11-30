using LatijnLogic.Interfaces;

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
                    newNumber = random.Next(totalAmount);
                } while (randomNumbers.Contains(newNumber));
                randomNumbers.Add(newNumber);
            }
            return randomNumbers;
        }
    }
}
