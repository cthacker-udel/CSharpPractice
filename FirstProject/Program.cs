using System;
using System.Globalization;

namespace FirstProject
{
    class Program
    {

        public static string MonthName(int num) {

            return new DateTimeFormatInfo().GetMonthName(num);
        
        }

        static void Main(string[] args)
        {
            /*
             * 
             * Excercise 1
             * 
             */

            sbyte sbyte1;
            byte byte1;
            short short1;
            ushort ushort1;
            int int1;
            uint uint1;
            long long1;
            ulong ulong1;

            sbyte1 = -115;
            byte1 = 97;
            short1 = 224;
            ushort1 = 1190;
            int1 = -10000;
            uint1 = 20000;
            long1 = 4825932;
            ulong1 = 9707000000;

            string str1 = "Hello ";
            string str2 = "World!";
            Console.WriteLine(concatStr(str1, str2));

            Console.WriteLine(typeVerifier(str1));

            Console.WriteLine(str1 ?? "left is null");

            object nullableObj = null;
            Console.WriteLine(nullableObj ?? "left is null2");

            Console.WriteLine(3.ToString());

            int maxVal = UInt16.MaxValue;

            float floatPI = 3.14f;

            Console.WriteLine(floatPI);

            double nan = Double.NaN;
            Console.WriteLine(nan);


            int a = 10;
            int b = 20;

            bool aGb = a > b;
            bool aLb = a < b;
            bool aEb = a == b;

            if (aGb)
            {
                Console.WriteLine("A is greater than B");
            }
            else if (aLb)
            {
                Console.WriteLine("A is less than B");
            }
            else 
            {
                Console.WriteLine("A is equal to B");
            }

            string firstName = "Cameron";
            string lastName = "Thacker";

            Console.WriteLine("Your Name is : " + firstName + " " + lastName);

            object refInt = 10;
            object refStr = "Object reference to a string";

            int? nullInt = 10;
            int? nullInt2 = null;

            string? str3 = "str1";
            string? str4 = null;

            double? dbl1 = 1.0;
            double? dbl2 = null;

            if (dbl1.HasValue)
            {
                Console.WriteLine("Double1 has a value of " + dbl1);
            }
            else {
                Console.WriteLine("Double1 has a null value");
            }


        }

        public static bool isEven(int number) {
            return number % 2 == 0;
        }

        public static bool isOdd(int number) {
            return number % 2 != 0;
        }

        public static bool isFizzBuzz(int number) {
            return number % 5 == 0 && number % 7 == 0;
        }

        public static bool thirdBit(int number) {
            string binaryString = Convert.ToString(number, 2);
            if (binaryString.Length > 2)
            {
                // check if third bit is 1
                return binaryString[2].Equals("1");
            }
            else {
                return false;
            }
        }

        public static int trapezoidArea(int a, int b, int h) {
            return ((a + b) / 2) * h;
        }

        static string typeVerifier(object value) {

            if (value is string)
            {
                return "string";
            }
            else if (value is int)
            {
                return "int";
            }
            else if (value is long)
            {
                return "long";
            }
            else if (value is decimal) {
                return "decimal";
            }
            else
            {
                return "unknown";
            }
        
        }


        static string concatStr(string str1, string str2) {
            return str1 + str2;
        }

        static string compare(double val1, double val2) {

            if (Math.Abs(val1 - val2) < 0.00001)
            {
                return "same";
            }
            else {
                return "different";
                // commit
            }
        
        }
    }
}
