using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class BaseDivider
    {
        public virtual double Divide(double a, double b)
        {
            Console.WriteLine("Devide Integer Numbers");
            if ((int)b == 0)
            {
                Console.WriteLine("Devide by Zero");
                return 0;
            }
            else
            {
                return (int)a / (int)b; // تقسیم اعداد بصورت عدد صحیح
            }

        }

    }
    class DecimalDivider : BaseDivider
    {
        public override double Divide(double a, double b)
        {
            Console.WriteLine("Devide Double Numbers");
            if (b == 0)
            {
                Console.WriteLine("Devide by Zero");
                return 0;
            }
            return a / b; // تقسیم اعداد بصورت عدد اعشاری
        }
    }

}
