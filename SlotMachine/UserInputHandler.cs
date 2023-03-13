using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    public class UserInputHandler
    {
        public decimal GetValidDecimalFromUserInput(bool isStake)
        {
            Console.WriteLine(isStake ? "Enter stake amount: " : "Please deposit money you would like to play with:");
            decimal money = 0;
            bool isDecimal = decimal.TryParse(Console.ReadLine(), out money);
            while (!isDecimal || money <= 0)
            {
                Console.WriteLine("Please enter a valid positive number");
                isDecimal = decimal.TryParse(Console.ReadLine(), out money);
            }
            return money;
        }
    }
}
