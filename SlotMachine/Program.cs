using Microsoft.Extensions.DependencyInjection;
using SlotMachine.Interfaces;

namespace SlotMachine
{
    public class Program
    {
        public static void Main()
        {
            var serviceProvider = new ServiceCollection()
            .AddSingleton<IMachineCalculator, MachineCalculator>()
            .AddSingleton<IRandomNumberGenerator, RandomNumberGenerator>()
            .AddSingleton<ISpinGenerator, SpinGenerator>()
            .AddSingleton<IUserInputHandler, UserInputHandler>()
            .AddSingleton<ISlotMachine, SlotMachine>()
            .BuildServiceProvider();

            var slotMachine = serviceProvider.GetService<ISlotMachine>();
            slotMachine.Run();
        }
    }
}
