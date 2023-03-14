
namespace SlotMachine
{
    public class Program
    {
        public static void Main()
        {
            var userInputHandler = new UserInputHandler();
            var spinGenerator = new SpinGenerator();
            var machineCalculator = new MachineCalculator();

            var slotMachine = new SlotMachine(machineCalculator, spinGenerator, userInputHandler);
            
            slotMachine.Run();
        }
    }
}
