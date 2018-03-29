using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class CalcServiceCallbackSink : CalcServiceReference.ICalcServiceCallback
    {
        public void Calculated(int nOp, double dblNum1, double dblNum2, double dblResult)
        {
            Console.WriteLine("(" + nOp + " " + dblNum1 + " " + dblNum2 + " ) = " + dblResult);
        }

        public void CalculationFinished()
        {
            Console.WriteLine("Finish calculation");
        }
    }
}
