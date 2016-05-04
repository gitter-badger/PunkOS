
namespace PunkOS.Core
{
    public class CPU
    {
        public static uint GetMemory() { return Cosmos.Core.CPU.GetAmountOfRAM() + 1; }
        public static uint GetUsedMemoryByKernel() { return Cosmos.Core.CPU.GetEndOfKernel() / 1024 / 1024; }
        //public static uint GetUsedMemoryTotal() { return DuNodes.Kernel.Base.Core.Heap.GetTotalUsedMemory(); }
        public static void AllocMemory(uint aLength) { Cosmos.Core.Heap.MemAlloc(aLength); }
        //public static void Reboot() { Cosmos.HAL.Power.Reboot(); }
        //public static void Halt() { DuNodes.HAL.Core.Power.Halt(); }
    }
}
