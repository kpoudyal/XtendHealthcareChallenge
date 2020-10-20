using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XtendHealthcareChallenge
{
    public interface IMathClass
    {
        int Multiply(int a, int b);
        int Multiply_BadImplementation(int a, int b);
        int Multiply(params int[] numbers);
    }
}