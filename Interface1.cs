using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Calculator
{
    
    public interface IMathBasicOperation
    {
        double Calculate(double num1, double num2);
    }

    public class Addition : IMathBasicOperation
    {
        public double Calculate(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    public class Subtraction : IMathBasicOperation
    {
        public double Calculate(double num1, double num2)
        {
            return num1 - num2;
        }
    }
    public class Multiplication : IMathBasicOperation
    {
        public double Calculate(double num1, double num2)
        {
            return num1 * num2;
        }
    }

    public class Division : IMathBasicOperation
    {
        public double Calculate(double num1, double num2)
        {
            return num1 / num2;

        }
    }

}
