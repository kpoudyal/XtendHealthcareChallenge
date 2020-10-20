using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XtendHealthcareChallenge.Implementation;

namespace XtendHealthcareChallenge.Services
{
    public class MathServices
    {
        public IMathClass MathClass { get; set; }
        public MathServices()
        {
            MathClass = new MathClass();
        }

        public int MultiplyNumbers(int a , int b)
        {                  
          return MathClass.Multiply(a, b);  
        }

        public int MultiplyUnlimitedNumbers(params int[] numbers)
        {
            return MathClass.Multiply(numbers);
        }

    }
}
