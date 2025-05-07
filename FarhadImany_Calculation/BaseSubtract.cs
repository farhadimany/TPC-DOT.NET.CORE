using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class BaseSubtract
    {
        public virtual double Subtract(double a, double b)
        {
            Console.WriteLine("Subtract of integer number");
            return (int)a - (int)b; // / تفریق اعداد بصورت عدد صحیح

        }
    }
    class DecimalSubtract : BaseSubtract
    {
        public override double Subtract(double a, double b)
        {
            Console.WriteLine("Subtract of Double number");
            return a - b; // / تفریق اعداد بصورت عدد اعشاری
        }
    }
}
