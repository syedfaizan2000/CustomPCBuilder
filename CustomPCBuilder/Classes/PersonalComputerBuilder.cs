using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomPCBuilder.Interfaces;
using CustomPCBuilder.Classes;
namespace CustomPCBuilder
{
    class PersonalComputerBuilder : IPersonalComputerBuilder
    {
        private PersonalComputer _PersonalComputer = new PersonalComputer();
        public IPersonalComputerBuilder setChasis(IChasis chasis)
        {
            _PersonalComputer.Chasis = chasis;
            return this;
        }

        public IPersonalComputerBuilder setMotherboard(IMotherboard motherboard)
        {
            _PersonalComputer.Motherboard = motherboard;
            return this;
        }

        public IPersonalComputerBuilder setPowerSupplyUnit(IPowerSupplyUnit powerSupplyUnit)
        {
            _PersonalComputer.PowerSupplyUnit = powerSupplyUnit;
            return this;
        }

        public IPersonalComputerBuilder setProcessor(IProcessor processor)
        {
            _PersonalComputer.Processor = processor;
            return this;
        }

        public IPersonalComputerBuilder setRam(IRam ram)
        {
            _PersonalComputer.Ram = ram;
            return this;
        }

        public double GetCost()
        {
           return  _PersonalComputer.CalculateCost();
        }

        public PersonalComputer Build()
        {
            return _PersonalComputer;
        }
    }
}
