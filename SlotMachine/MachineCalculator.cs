using SlotMachine.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    public class MachineCalculator
    {
        private decimal _win;

        public decimal CalculateWin(char[,] matrix, decimal stake)
        {
            _win = 0;
            for (int i = 0; i < 4; i++)
            {
                string row = new string(new char[] { matrix[i, 0], matrix[i, 1], matrix[i, 2] });
                var distinctCount = row.Distinct().Count();

                if (distinctCount == 1)
                {
                    _win += CalculateForSymbols(row, stake, calculateStars: false);
                }
                else if (distinctCount == 2 && row.Contains(Constants.Star))
                {
                    _win += CalculateForSymbols(row, stake, calculateStars: true);
                }
            }
            return _win;
        }
        
        // You can write this method using ternary operator which is a shorter way to write if-else statements 
        private decimal CalculateForSymbols(string row, decimal stake, bool calculateStars)
        {
            int starCount = row.Count(c => c == Constants.Star);

            var multiplier = calculateStars ? (starCount == 1 ? 2 : 1) : 3;

            var tempWin = row.Contains(Constants.Apple) ? Constants.AppleCoefficient * multiplier * stake :
                          (row.Contains(Constants.Banana) ? Constants.BananaCoefficient * multiplier * stake :
                          (row.Contains(Constants.Pineapple) ? Constants.PineappleCoefficient * multiplier * stake : 0));

            return tempWin;
        }

        public decimal CalculateTotalCash(decimal money)
        {
            return money += _win;
        }
    }
}
