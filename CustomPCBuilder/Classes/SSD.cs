using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder
{
    class SSD : ISSD
    {
        string ISSD.ModelName { get ; set ; }
        int ISSD.TDP { get ; set ; }
        bool ISSD.Mandatory { get ; set ; }
        double ISSD.Price { get ; set ; }
    }
}
