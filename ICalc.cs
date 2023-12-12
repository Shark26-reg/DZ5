using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal interface ICalc
    {
        event EventHandler<EventArgs> GotResult;
        double Sum(double value);
        double Substruct(double value);
        double Multiply(double value);
        double Divide(double value);
    }
}
