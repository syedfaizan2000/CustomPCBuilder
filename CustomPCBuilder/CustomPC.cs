using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder
{
    class CustomPC
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
        public List<ISSD> SsdList = new List<ISSD>();
        public List<IRam> RamList = new List<IRam>();

        public CustomPC(IProcessor processor, IMotherboard motherboard, IRam ram, IChasis chasis, IPowerSupplyUnit powerSupplyUnit)
        {
            Processor = processor;
            Motherboard = motherboard;
            Ram = ram;
            Chasis = chasis;
            PowerSupplyUnit = powerSupplyUnit;
            RamList.Add(Ram);
        }
        public CustomPC()
        {
            Processor = new Processor();
            Motherboard = new Motherboard();
            Ram = new Ram();
            Chasis = new Chasis();
            Ssd = new SSD();
            PowerSupplyUnit = new PowerSupplyUnit();
            Ssd.Price = Processor.Price = PowerSupplyUnit.Price = Motherboard.Price = Ram.Price = 0;
        }
        public void AddOptionalSSD(ISSD ssd)
        {
            SsdList.Add(ssd);
        }

        public void AddOptionalHDD()
        {

        }

        public double CalculateCost()
        {
            return Processor.Price + Motherboard.Price + Ram.Price + Chasis.Price + PowerSupplyUnit.Price;
        }
    }
}
