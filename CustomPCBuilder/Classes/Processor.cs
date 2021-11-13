using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder
{
    class Processor : IProcessor
    {
        public string ModelName { get ; set ; }
        public int Cores { get ; set ; }
        public int Threads { get ; set ; }
        public int TDP { get ; set ; }
        public bool Mandatory { get ; set ; }
        public double Price { get; set ; }
        public string Socket { get ; set ; }
    }
}
