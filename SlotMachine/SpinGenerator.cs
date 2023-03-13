using SlotMachine.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    public class SpinGenerator
    {
        private RandomNumberGenerator _randomNumberGenerator;

        public SpinGenerator()
        {
            _randomNumberGenerator = new RandomNumberGenerator();
        }

        public char[,] GenerateSpin()
        {
            char[,] matrix = new char[4, 3];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int randomNum = _randomNumberGenerator.GenerateRandomNumber(0, 100);
                    if (randomNum < Constants.ChanceForApple)
                    {
                        matrix[i, j] = Constants.Apple;
                    }
                    else if (randomNum < Constants.ChanceForApple + Constants.ChanceForBanana)
                    {
                        matrix[i, j] = Constants.Banana;
                    }
                    else if (randomNum < Constants.ChanceForApple + Constants.ChanceForBanana + Constants.ChanceForPineapple)
                    {
                        matrix[i, j] = Constants.Pineapple;
                    }
                    else
                    {
                        matrix[i, j] = Constants.Star;
                    }
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            return matrix;
        }
    }
}
