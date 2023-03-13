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
        private UserInputHandler _userInputHandler;
        private SpinGenerator _spinGenerator;
        private MachineCalculator _machineCalculator;

        public SlotMachine()
        {
            _userInputHandler = new UserInputHandler();
            _spinGenerator = new SpinGenerator();
            _machineCalculator = new MachineCalculator();
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
