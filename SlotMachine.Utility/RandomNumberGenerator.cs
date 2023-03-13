using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    public class RandomNumberGenerator
    {
        private Random random;

        public RandomNumberGenerator()
        {
            random = new Random();
        }

        public int GenerateRandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
