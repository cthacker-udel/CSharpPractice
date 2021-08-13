using System;
using System.Globalization;
using System.Collections.Generic;

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


            int[] arr = { 1, 2, 3, 4 };

            foreach (int elem in arr) {
                Console.WriteLine(elem);
            }

            int total = 0;

            foreach (int elem in arr) {
                total += elem;
            }
            Console.WriteLine(total);


            Console.WriteLine("Enter the number of lines of triangle to print");

            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++) {
                for (int j = 1; j <= i; j++) {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            int m;
            int n;
            do
            {
                Console.WriteLine("Enter the beginning of the interval");
                m = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the end of the interval");
                n = int.Parse(Console.ReadLine());
            } while (m < 0 || n < 0);

            if (n < m) {
                int temp = m;
                m = n;
                n = temp;
            }

            while (m <= n) {
                if (isPrime(m)) {
                    Console.WriteLine(m);
                }
                m++;
            }

            Console.WriteLine("Print if number is lucky, input must be 4 digit number");
            do
            {
                m = int.Parse(Console.ReadLine());
            } while (m < 1000 || m > 9999);

            // convert to string
            string mString = m.ToString();
            int m1 = mString[0];
            int m2 = mString[1];
            int m3 = mString[2];
            int m4 = mString[3];

            if (m1 + m2 == (m3 + m4))
            {
                Console.WriteLine(m + " is a lucky number!");
            }
            else {
                Console.WriteLine(m + " is not a lucky number!");
            }

            printMinMax();

            */

            //printCards();

            //fibN(10);

            Console.Write(nFactorialK(5, 7));

     


        }

        public static void print1ToN(int n) {

            for (int i = 1; i <= n; i++) {
                Console.WriteLine(i);
            }

        }

        public static void print1ToNNot1Or3(int n) {
            for (int i = 1; i <= n; i++)
            {

                if (i % 3 == 0 && i % 7 == 0)
                {
                    continue;
                }
                else {
                    Console.WriteLine(i);
                }

            }
        }

        public static void printMinMax()
        {
            ulong r;
            ulong max = 1;
            ulong min = 1;
            Console.WriteLine("Enter numbers to generate max and min of numbers entered, enter 0 to end");
            do
            {
                Console.WriteLine("Enter number");
                r = ulong.Parse(Console.ReadLine());
                min = Math.Min(r, min);
                max = Math.Max(r, max);
            } while (r != 0);

            Console.WriteLine("The max variable is : " + max);
            Console.WriteLine("The min variable is : " + min);

        }

        public static void printCards() {

            string[] suits = { "Clubs", "Hearts", "Spades", "Diamonds" };
            string[] ranks = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            for (int i = 0; i < suits.Length; i++) {
                for (int j = 0; j < ranks.Length; j++) {
                    Console.WriteLine(String.Format("{0} of {1}", ranks[j], suits[i]));
                }
            }




        }

        public static void fibN(int n) {
            int start = 1;
            List<Int32> fib = new List<Int32>();
            fib.Add(1);
            while (start <= n) {
                if (fib.Count < 2)
                {
                    fib.Add(1);
                    start++;
                }
                else {
                    fib.Add(fib[start - 2] + fib[start - 1]);
                    start++;
                }
            }

            for (int i = 0; i < fib.Count; i++) {
                Console.Write(String.Format("{0} ", fib[i]));
            }
            Console.WriteLine("");

        }


        public static int factorial(int num) {

            if (num == 1)
            {
                return 1;
            }
            else {
                return factorial(num - 1) * num;
            }

        }

        public static double nFactorialK(int n, int k) {

            return (double)factorial(n) / (double)factorial(k);

        }

        public static double nFactorialKV2(int n, int k) {

            return ((factorial(n) * factorial(k)) / ((double)factorial(n - k)));
            //


        }





        public static bool isPrime(int number) {

            if (number <= 2)
            {
                return true;
            }
            else if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0)
            {
                return false;
            }
            else {
                for (int i = 2; i < ((int)Math.Sqrt(number)); i++) {
                    if (number % i == 0) {
                        return false;
                    }
                }
                return true;
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

        public static void rectanglePrint(int width, int length) {
            Console.WriteLine("Area is : " + (width + length));
            Console.WriteLine("Perimeter is : " + (2 * (length + width)));
        }

        public static void moonWeight(int weight) {
            double gravityMoon = 9.18 / .17;
            weight = weight - (int)(weight * gravityMoon);
            Console.WriteLine("The weight on the moon is : " + weight + "lbs");
        }

        public string calcFourDigitNumber(int number) {
            string numStr = Convert.ToString(number);
            int digitSum = 0;
            for (int i = 0; i < numStr.Length; i++) {
                char theDigit = numStr[i];
                digitSum += Int32.Parse(theDigit+"");
            }
            Console.WriteLine("The sum of the digits of " + number + " is : " + digitSum);
            for (int i = numStr.Length - 1; i >= 0; i--) {
                Console.Write(numStr[i]);
            }
            char firstChar = numStr[0]; // 1234
            string newStr = numStr[numStr.Length - 1] + numStr.Substring(1, numStr.Length - 2) + firstChar;
            string newStr2 = numStr[0] + "" + numStr[2] + numStr[1] + numStr[numStr.Length - 1];
            Console.WriteLine(newStr);
            Console.WriteLine(newStr2);
            return "";
        
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
