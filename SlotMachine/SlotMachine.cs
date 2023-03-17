using SlotMachine.Interfaces;
using SlotMachine.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    public class SlotMachine : ISlotMachine
    {
        private readonly IUserInputHandler _userInputHandler;
        private readonly ISpinGenerator _spinGenerator;
        private readonly IMachineCalculator _machineCalculator;

        public SlotMachine(IUserInputHandler userInputHandler, ISpinGenerator spinGenerator, IMachineCalculator machineCalculator)
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
