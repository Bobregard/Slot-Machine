using SlotMachine.Interfaces;

namespace SlotMachine
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private Random random = new Random();

        public int GenerateRandomNumber()
        {
            return random.Next(0, 100);
        }
    }
}
