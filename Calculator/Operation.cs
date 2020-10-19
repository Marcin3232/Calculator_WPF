using Serilog;
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
            switch (currentOperation)
            {
                case string c when c.Contains('+'):
                    {
                        var element = currentOperation.Split('+');
                        return result = double.Parse(element[0]) + double.Parse(element[1]);                      
                    }
                case string c when c.Contains('-'):
                    {
                        var element = currentOperation.Split('-');
                        return result = double.Parse(element[0]) - double.Parse(element[1]);
                    }
                case string c when c.Contains('*'):
                    {
                        var element = currentOperation.Split('*');
                        return result = double.Parse(element[0]) * double.Parse(element[1]);
                    }
                case string c when c.Contains('/'):
                    {
                        var element = currentOperation.Split('/');
                        return result = double.Parse(element[0]) / double.Parse(element[1]);
                    }
                case string c when c.Contains('%'):
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
                default:
                    {
                        return 0;
                    }
            }
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
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
