using SlotMachine.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    public class SlotMachine
    {
        // Make 3 interfaces and inject them in the constructor here (DIP principle from SOLID) instead of sticking to other components
        private IUserInputHandler _userInputHandler;
        private ISpinGenerator _spinGenerator;
        private IMachineCalculator _machineCalculator;

        public SlotMachine(IMachineCalculator machineCalculator, ISpinGenerator spinGenerator, IUserInputHandler userInputHandler)
        {
            _userInputHandler = userInputHandler;
            _spinGenerator = spinGenerator;
            _machineCalculator = machineCalculator;
        }

        public void Run()
        {
            decimal money = _userInputHandler.GetValidDecimalFromUserInput(isStake: false);
            while (money > 0)
            {
                decimal stake = _userInputHandler.GetValidDecimalFromUserInput(isStake: true);
                if (money < stake)
                {
                    Console.WriteLine("You don't have enough money for this stake.");
                    continue;
                }

                money -= stake;
                char[,] matrix = _spinGenerator.GenerateSpin();
                decimal win = _machineCalculator.CalculateWin(matrix, stake);
                decimal totalCash = _machineCalculator.CalculateTotalCash(money);
                Console.WriteLine($"You have won: {win}");
                Console.WriteLine($"Current balance: {totalCash}");
                money = totalCash;
            }
        }
    }
}
