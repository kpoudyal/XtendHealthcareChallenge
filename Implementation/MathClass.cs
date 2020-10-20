using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtendHealthcareChallenge.Implementation
{
    public class MathClass : IMathClass
    {
        public int Multiply_BadImplementation(int a, int b)
        {
            int returnVal = 0;
            for (int i = 0; i <= a; i++)
            {
                returnVal += b;
            }
            Console.WriteLine("Their multiplication value is {0}", returnVal);
            return returnVal;
        }




        public int Multiply(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new  Exception("Number must be a positive integer.");

            checked
            {
                int number = 0;
                try
                {
                    number = a * b;
                }
                catch (OverflowException ex)
                {
                    throw new OverflowException(ex.Message);
                }
                catch (Exception)
                {

                    throw;
                }
                Console.WriteLine("Their multiplication value is {0}", number);
                return number;

            }


        }

        public int Multiply(params int[] numbers)
        {
            int number = 0;

            try
            {
                checked
                {
                    foreach (int i in numbers)
                    {
                        // this is just for requirement number should be greater than 0
                        if (i > 0)
                        {
                            number = number + i;
                        }
                    }
                }

            }
            catch (OverflowException ex)
            {
                throw new OverflowException(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something unexpected happend " + ex.Message);
                throw;
            }           
            Console.WriteLine("Their multiplication value is {0}", number);
            return number;
        }
    }
}
