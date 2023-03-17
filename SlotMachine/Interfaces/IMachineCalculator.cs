
namespace SlotMachine.Interfaces
{
    public interface IMachineCalculator
    {
        decimal CalculateWin(char[,] matrix, decimal stake);
        decimal CalculateTotalCash(decimal money);
    }
}
