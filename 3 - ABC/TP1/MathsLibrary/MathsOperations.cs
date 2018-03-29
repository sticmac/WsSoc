using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public class MathsOperations : IMathsOperations
    {
        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }

        public int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }

        public float Divide(float num1, float num2)
        {
            if (num2 == 0)
            {
                CustomFaultDetails ex = new CustomFaultDetails
                {
                    ErrorId = "12345",
                    ErrorDetails = "Cannot divide by 0"
                };
                throw new FaultException<CustomFaultDetails>(ex, "Cannot divide by 0");
            }
            return num1 / num2;
        }
    }
}
