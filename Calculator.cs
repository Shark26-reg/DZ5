using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal class Calculator : ICalc
    {
        public event EventHandler<EventArgs> GotResult;

        public double Result = 0;

        public double Sum(double value)
        {
            Result += value;
            RaiseEvent();
            return Result; 
        }

        public double Multiply(double value)
        {
            Result *= value;
            RaiseEvent();
            return Result;
        }
        public double Divide(double value)
        {
            if (value == 0)
            {
                throw new DivideByZeroException("На 0 делить нельзя");
            }
            else
            {
                Result /= value;
                RaiseEvent();
                return Result;
            }
             
        }
        public double Substruct(double value)
        {
            Result -= value;
            RaiseEvent();
            return Result;
        }
        private void RaiseEvent()
        {
            GotResult?.Invoke(this, EventArgs.Empty);
        }   
               
    }
}
