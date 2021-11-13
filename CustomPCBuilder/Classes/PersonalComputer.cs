using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CustomPCBuilder.Classes
{
    class PersonalComputer
    {
        public IProcessor Processor;
        public IMotherboard Motherboard;
        public IRam Ram;
        public IChasis Chasis;
        public ISSD Ssd;
        public IGpu Gpu;
        public ICpuCooler CpuCooler;
        public IGpuCooler GpuCooler;
        public IPowerSupplyUnit PowerSupplyUnit;

        public PersonalComputer(IProcessor processor, IMotherboard motherboard, IRam ram, IChasis chasis, IPowerSupplyUnit powerSupplyUnit)
        {
            Processor = processor;
            Motherboard = motherboard;
            Ram = ram;
            Chasis = chasis;
            PowerSupplyUnit = powerSupplyUnit;
        }

        public PersonalComputer()
        {
        }
        public double CalculateCost()
        {
            return Chasis.Price + Processor.Price + Motherboard.Price + Ram.Price + PowerSupplyUnit.Price;
        }
    }
}
