using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operation
    {
        private double result;

        public double Result(string currentOperation)
        {
            try
            {
            if (currentOperation.Contains('+'))
            {
                var element = currentOperation.Split('+');
                return result = double.Parse(element[0]) + double.Parse(element[1]);
            }
            if (currentOperation.Contains('-'))
            {
                var element = currentOperation.Split('-');
                return result = double.Parse(element[0]) - double.Parse(element[1]);
            }
            if (currentOperation.Contains('/'))
            {
                var element = currentOperation.Split('/');
                return result = double.Parse(element[0]) / double.Parse(element[1]);
            }
            if (currentOperation.Contains('*'))
            {
                var element = currentOperation.Split('*');
                return result = double.Parse(element[0]) * double.Parse(element[1]);
            }
                if (currentOperation.Contains('%'))
                {
                    var element = currentOperation.Split('%');
                    if (element[1] == "")
                    {
                        return result = double.Parse(element[0]) / 100;
                    }
                    else
                    {
                        return result = double.Parse(element[0]) / 100 * double.Parse(element[1]);

                    }
                }

            }
            catch (Exception e)
            {
               

            }                  
            return 0;
        }

        public bool containSign(string currentOperation)
        {
                return currentOperation.Contains('+') || currentOperation.Contains('-') 
                || currentOperation.Contains('%') || currentOperation.Contains('/') 
                || currentOperation.Contains('*');             
        }

    }
}
