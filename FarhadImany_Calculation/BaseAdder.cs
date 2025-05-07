using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarhadImany_Calculation
{
    class BaseAdder
    {
        public virtual double Add(double a, double b)
        {
            Console.WriteLine("Sum of integer number");
            return (int)a + (int)b; // جمع اعداد بصورت عدد صحیح

        }
    }
    class DecimalAdder : BaseAdder
    {
        public override double Add(double a, double b)
        {
            Console.WriteLine("Sum of Double number");
            return a + b; // جمع اعداد بصورت عدد اعشاری
        }
    }

}
