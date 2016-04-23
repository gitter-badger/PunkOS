
namespace PunkOS.HAL
{
    public class CPU
    {
        public static uint GetMemory() { return Core.CPU.GetMemory(); }
        public static uint GetUsedMemoryByKernel() { return Core.CPU.GetUsedMemoryByKernel(); }
        public static void AllocMemory(uint aLength) { Core.CPU.AllocMemory(aLength); }

    }
}
