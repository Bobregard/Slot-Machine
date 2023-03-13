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

        private decimal CalculateForSymbols(string row, decimal stake, bool calculateStars)
        {
            int starCount = row.Count(c => c == Constants.Star);
            int multiplier;
            decimal tempWin = 0;

            if (!calculateStars)
            {
                multiplier = 3;
            }
            else if (starCount == 1)
            {
                multiplier = 2;
            }
            else
            {
                multiplier = 1;
            }

            if (row.Contains(Constants.Apple))
            {
                tempWin = Constants.AppleCoefficient * multiplier * stake;
            }
            else if (row.Contains(Constants.Banana))
            {
                tempWin = Constants.BananaCoefficient * multiplier * stake;
            }
            else if (row.Contains(Constants.Pineapple))
            {
                tempWin = Constants.PineappleCoefficient * multiplier * stake;
            }
            return tempWin;
        }

        public decimal CalculateTotalCash(decimal money)
        {
            return money += _win;
        }
    }
}
