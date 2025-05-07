using ConsoleApp6;

namespace FarhadImany_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, result;
            string operation;

            Console.WriteLine("Simple Calculator");
            Console.WriteLine("----------------------");
            // گرفتن عدد اول از کاربر
            Console.Write("Enter First Number: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            // گرفتن عملگر از کاربر
            Console.Write("Enter Operation (+, -, *, /): ");
            operation = Console.ReadLine();
            // گرفتن عدد دوم از کاربر            
            Console.Write("Enter Second Number: ");
            number2 = Convert.ToDouble(Console.ReadLine());
            // آغاز عملیات بر اساس ورودی کاربر
            switch (operation)
            {
                //------------------------------------اگر عملگر جمع بود-----------------------------------------------
                case "+":
                    BaseAdder adder;
                    if (number1 % 1 == 0 && number2 % 1 == 0)
                    {
                        adder = new BaseAdder();
                    }
                    else
                    {
                        adder = new DecimalAdder();
                    }
                    result = adder.Add(number1, number2);
                    Console.WriteLine("result: " + result);
                    break;
                //------------------------------------اگر عملگر تفریق بود-----------------------------------------------
                case "-":
                    BaseSubtract Subtracter;
                    if (number1 % 1 == 0 && number2 % 1 == 0)
                    {
                        Subtracter = new BaseSubtract();
                    }
                    else
                    {
                        Subtracter = new DecimalSubtract();
                    }
                    result = Subtracter.Subtract(number1, number2);
                    Console.WriteLine("result: " + result);
                    break;
                //------------------------------------اگر عملگر ضرب بود-----------------------------------------------
                case "*":
                    BaseMultiply Multiplyer;
                    if (number1 % 1 == 0 && number2 % 1 == 0)
                    {
                        Multiplyer = new BaseMultiply();
                    }
                    else
                    {
                        Multiplyer = new DecimalMultiply();
                    }
                    result = Multiplyer.Multiply(number1, number2);
                    Console.WriteLine("result: " + result);
                    break;
                //------------------------------------اگر عملگر تقسیم بود-----------------------------------------------
                case "/":
                    BaseDivider divider;
                    // اگر هر دو عدد بدون بخش اعشاری باشند، آن‌ها را صحیح در نظر بگیر
                    if (number1 % 1 == 0 && number2 % 1 == 0)
                    {
                        divider = new BaseDivider();
                    }
                    else
                    {
                        divider = new DecimalDivider();
                    }

                    result = divider.Divide(number1, number2);
                    Console.WriteLine("result: " + result);
                    break;
                default:
                    Console.WriteLine("Incorrect Operation");
                    break;
            }
            Console.WriteLine("To close Program Press any key");
            Console.ReadKey();
        }
    }
}