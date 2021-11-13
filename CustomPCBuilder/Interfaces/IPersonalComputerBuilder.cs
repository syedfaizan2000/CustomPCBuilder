using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder.Interfaces
{
    interface IPersonalComputerBuilder
    {
        public IPersonalComputerBuilder setProcessor(IProcessor processor);
        public IPersonalComputerBuilder setMotherboard(IMotherboard motherboard);
        public IPersonalComputerBuilder setRam(IRam ram);
        public IPersonalComputerBuilder setChasis(IChasis chasis);
        public IPersonalComputerBuilder setPowerSupplyUnit(IPowerSupplyUnit powerSupplyUnit);
    }
}
