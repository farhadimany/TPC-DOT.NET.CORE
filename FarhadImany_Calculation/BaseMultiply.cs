using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class BaseMultiply
    {
        public virtual double Multiply(double a, double b)
        {
            Console.WriteLine("Multiply of integer number");
            return (int)a * (int)b; // / ضرب اعداد بصورت عدد صحیح

        }

    }
    class DecimalMultiply : BaseMultiply
    {
        public override double Multiply(double a, double b)
        {
            Console.WriteLine("Multiply of Double number");
            return a * b; // ضرب اعداد بصورت عدد اعشاری
        }
    }

}
