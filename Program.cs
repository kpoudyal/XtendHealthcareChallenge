using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XtendHealthcareChallenge.Services;

namespace XtendHealthcareChallenge
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var service = new MathServices();
            //var number = service.MultiplyNumbers(1, 100);
            var unlimitedNumberTest = service.MultiplyUnlimitedNumbers(3, 3, 2147483647 );

        }
    }
}
