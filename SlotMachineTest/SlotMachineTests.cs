using NUnit.Framework;
using SlotMachine;

namespace SlotMachineTest
{
    public class SlotMachineTests
    {
        [Test]
        public void CalculatingResultForWin()
        {
            //Arange
            MachineCalculator machineCalculator = new MachineCalculator();
            char[,] matrix = { { 'A', 'A', 'A' }, { 'B', 'B', 'B' }, { 'P', 'P', 'P' }, { 'A', 'A', '*' } };
            int stake = 10;

            //Act
            decimal result = machineCalculator.CalculateWin(matrix, stake);
            //Assert
            Assert.AreEqual(62m, result);
        }
        [Test]
        public void CalculatingResultForLoss()
        {
            //Arange
            MachineCalculator machineCalculator = new MachineCalculator();
            char[,] matrix = { { 'B', 'A', 'A' }, { 'A', 'B', 'B' }, { 'A', 'B', 'P' }, { 'A', 'B', '*' } };
            int stake = 10;

            //Act
            decimal result = machineCalculator.CalculateWin(matrix, stake);
            //Assert
            Assert.AreEqual(0, result);
        }
    }
}