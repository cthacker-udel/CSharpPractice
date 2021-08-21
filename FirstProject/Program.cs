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

            //Console.Write(nFactorialK(5, 7));

            /*

            int[] array = new int[6];

            int[] initializeArr = { 1, 2, 3, 4, 5 };

            string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            initializeArr[0] = 100;

            for (int i = 0; i < array.Length; i++) {
                array[i] = i + 1;
            }

            int[] revInitArr = new int[5];

            for (int i = initializeArr.Length - 1,j=0; i >= 0 && j < initializeArr.Length; i--,j++) {
                revInitArr[j] = initializeArr[i];
            }

            foreach (int elem in initializeArr) {
                Console.WriteLine(elem);
            }

            Console.WriteLine("\nThe days of the week are : \n");
            foreach (string elem in daysOfTheWeek) {
                Console.WriteLine(elem);
            }

            int[,] twoDimensionalArray;

            int[,,] threeDimensionalArray;

            string[,,] stringMultiDimensional;

            int[,] mallocInt = new int[3, 2];

            int[,,] mallocThreeInt = new int[3, 2, 3];

            int[,] matrix = {
                {1,2,3,4},
                {5,6,7,8},
            };

            Console.WriteLine(matrix[0,2]);


            int[,,] matrix3d =
            {
                {

                    {1,2,3,4},
                    {5,6,7,8},

                },
                {
                    {9,10,11,12},
                    {13,14,15,16},

                },


            };

            Console.WriteLine(matrix3d[0, 0, 2]);

            matrix.GetLength(0); // get # rows
            matrix.GetLength(1); // get # colums

            int[,] printMatrix =
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},


            };

            for (int i = 0; i < printMatrix.GetLength(0); i++) {
                for (int j = 0; j < printMatrix.GetLength(1); j++) {
                    Console.Write(printMatrix[i, j]);
                }
                Console.WriteLine("");
            }

            int[][] jaggedArray;
            jaggedArray = new int[2][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[7];

            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < jaggedArray[i].Length; j++) {
                    jaggedArray[i][j]++;
                }
            }

            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < jaggedArray[i].Length; j++) {
                    Console.Write("{0}", jaggedArray[i][j]);
                }
                Console.WriteLine("{0}", "");
            }

            // remember to do exercises chapter 

            Console.WriteLine(sumArgs(1, 2, 3, 10, 20));

            

            //Console.WriteLine("before printPeriod");
            //Console.WriteLine(printPeriod(0, 4));
            //Console.WriteLine("after printPeriod");

            //Console.WriteLine(displayTime());

            //int[] arr = { 124, 12, 5234, 231 };
            //Console.WriteLine("\nBefore sort\n");
            //for (int i = 0; i < arr.Length; i++) {
            //    Console.Write(arr[i] + ",");
            //}
            //arr = Sort(arr);
            //Console.WriteLine("\nAfter sort\n");
            //for (int i = 0; i < arr.Length; i++) {
            //    Console.Write(arr[i] + ",");
            //}

            //int[] arr = { 1, 142, 213, 51, 524, 1524, 141 };
            //descendingOrder(arr);

            //nLoopsK(1, 4,4);

            // page 392

            //Dog newDog = new Dog("sparky", "red", "husky");
            //Cat newCat = new Cat("meow", "tasmanian", "black", 3, 8, 37);
            //newDog.Bark();

            /Console.WriteLine(String.Format("Counter's current value is : {0}", Counter.counter));
            //Counter.increment();
            Counter.increment();
            Console.WriteLine(String.Format("Counter's current value is : {0}", Counter.counter));

            // test run


            int start = Environment.TickCount;

            for (long i = 0; i < 1000000000; i++) {
            }

            int end = Environment.TickCount;

            Console.WriteLine("The amount of time elapsed is : {0}", (end - start) / 1000);

            Random random = new Random();

            for (int i = 0; i < 6; i++) {

                Console.WriteLine("random value : {0}", random.Next(49) + 1);

            }

            */

            Random random = new Random();

            int randomLen = random.Next(15) + 8;
            string pass = " ".PadRight(randomLen);

            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lower = "abcdefghijklmnopqrstuvwxyz";

            int third = (int)Math.Floor((double)pass.Length / 3);

            int total = 0;

            do
            {

                int index = random.Next(pass.Length-1);
                if (pass[index] != ' ') {
                    // index occupied
                    continue;
                }
                pass = pass.Insert(index, random.Next(9).ToString());// = random.Next(9);
                total++;

            } while (total != 3);

            total = 0;

            do
            {

                int index = random.Next(pass.Length-1);
                if (pass[index] != ' ')
                {
                    // occupied
                    continue;
                }
                pass = pass.Insert(index, upper[random.Next(upper.Length - 1)].ToString());
                total++;
            } while (total != 3);

            total = 0;

            do
            {

                int index = random.Next(pass.Length - 1);
                if (pass[index] != ' ') {
                    continue;
                }
                pass = pass.Insert(index, lower[random.Next(lower.Length - 1)].ToString());
                total++;

            } while (total != 3);

            string newpass = "";
            for (int i = 0; i < pass.Length; i++) {
                char theChar = pass[i];
                if (theChar == ' ')
                {
                    continue;
                }
                else {
                    newpass += theChar;
                }
            }

            Console.WriteLine("The password is : {0}", newpass);

            // page 402

            


        }

        public static bool CheckEquality(Object obj1, Object obj2) {
            return obj1.Equals(obj2);
        }

        public static string ReverseCase(string aStr) {

            string tmpStr = "";
            for (int i = 0; i < aStr.Length; i++) {
                char iChar = aStr[i];
                if (Char.IsUpper(iChar))
                {
                    tmpStr += Char.ToLower(iChar);
                }
                else {
                    tmpStr += Char.ToUpper(iChar);
                }
            }
            return tmpStr;
        
        }

        public static string Reverse(string aStr) {

            string tmpStr = "";
            for (int i = aStr.Length - 1; i >= 0; i--) {
                tmpStr += aStr[i];
            }
            return tmpStr;
        
        }

        public static void solveEquatiuon(int number) {
            string numStr = number.ToString();
            string newStr = "";
            for (int i = numStr.Length - 1; i >= 0; i--) {
                newStr += numStr[i];
            }
            int avg = 0;
            for (int i = 0; i < newStr.Length; i++) {
                avg += Int32.Parse(newStr[i] + "");
            }
            avg = avg / newStr.Length;
            Console.WriteLine(String.Format("The avg of the reversed number {0} is : {1}", newStr, avg));

            Console.WriteLine("\nPlease enter a to solve the linear equation a*x+b=0");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease enter b to solve the linear equation a*x+b=0");
            int b = int.Parse(Console.ReadLine());
            int x = (-1 * b) / a;
            Console.WriteLine(String.Format("\nx = {0}", x));
        }

        public static bool polynomial1(int x) {
            return (3 * Math.Pow(x, 2) + x - 3) + (x - 1) == (3 * Math.Pow(x, 2) + 2 * x - 4);
        }

        public static bool polynomial2(int x) {
            return (3 * Math.Pow(x, 2) + x - 3) * (x - 1) == (3 * Math.Pow(x, 3) - 2 * Math.Pow(x, 2) - 4 * x + 3);
        }

        public static long Fib(int n) {
            if (n <= 2)
            {
                return 1;
            }
            else {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

        public static long factorial2(int n) {
            if (n <= 1)
            {
                return 1;
            }
            else {
                return factorial2(n - 1) * n;
            }
        }

        public static void nLoopsK(int n, int k, int tmpAmt) {

            if (k == 0)
            {
                return;
            }
            else {
                for (int i = 1; i <= tmpAmt; i++) {
                    Console.WriteLine(String.Format("{0} {1}", n, i));
                }
                nLoopsK(n + 1, k - 1, tmpAmt);
            }
        
        }

        public static int[] Sort(int[] numbers) {
            bool loopExit = false;
            while (true) {
                for (int i = 0; i < numbers.Length - 1; i++) {
                    int i1 = numbers[i];
                    int i2 = numbers[i + 1];
                    if (i1 > i2)
                    {
                        int temp = i1;
                        numbers[i] = i2;
                        numbers[i + 1] = i1;
                        loopExit = false;
                        break;
                    }
                    else {
                        loopExit = true;
                    }
                }
                if (loopExit) {
                    break;
                }
            }
            return numbers;
        }

        public static string printName(string name) {
            return String.Format("Hello, {0}!", name);
        }

        public static int getMax(params int[] vals)
        {
            int max = 0;
            for (int i = 0; i < vals.Length; i++) {
                max = Math.Max(max, vals[i]);
            }
            return max;
        }

        public static string lastDigit(int number) {
            int lastdigit = number % 10;
            switch (lastdigit) {
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";
                default:
                    return "default";
            }
        }

        public static bool checkNeighbors(int ind, int[] arr) {
            if (ind <= arr.Length - 3 && ind >= 0)
            {
                return arr[ind] > arr[ind + 1] && arr[ind] > arr[ind + 2];
            }
            else {
                return false;
            }
        }

        public static int countOccurences(int elem, int[] arr) {
            int count = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == elem) {
                    count++;
                }
            }
            return count;
        }

        public static int greaterThanNeighbors(int number, int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                if (checkNeighbors(i, arr)) {
                    return arr[i];
                }
            }
            return -1;
        }

        public static void printReverseNum(int number) {
            string numStr = number.ToString();
            for (int i = numStr.Length - 1; i >= 0; i--) {
                Console.Write(numStr[i]);
            }
            Console.WriteLine("\n");
        }

        public static long[] sumTwoLong(long[] num1, long[] num2) {

            int minLen = Math.Min(num1.Length, num2.Length);

            long[] arr = new long[100000];
            long carry = 0;
            int finalIndex = minLen == num1.Length ? num2.Length : minLen == num2.Length ? num1.Length : num2.Length;

            for (int i = 0; i < minLen; i++) {
                long addition = num1[i] + num2[i];
                if (addition >= 10)
                {
                    long cryAmt = Math.Abs(addition - 9);
                    if (carry > 0)
                    {
                        // carry has already been used, still in use
                        carry += cryAmt;
                    }
                    // check if carry already has been initialized
                    // else, assign carry
                    else
                    {
                        carry = Math.Abs(addition - 9);
                    }
                    arr[i] = 0;
                }
                else {
                    if (carry > 0) {
                        addition += carry;
                        if (addition >= 10)
                        {
                            long cryAmt = Math.Abs(addition - 9);
                            carry += cryAmt;
                            addition -= cryAmt;
                            arr[i] = 0;
                        }
                        else
                        {
                            arr[i] = addition;
                        }
                    }
                }
            }
            if (minLen == num1.Length)
            {
                for (int i = finalIndex; i < num2.Length; i++)
                {
                    arr[i] = num2[i];
                }
                return arr;
            }
            else if (minLen == num2.Length)
            {
                for (int i = finalIndex; i < num2.Length; i++)
                {
                    arr[i] = num1[i];
                }
                return arr;
            }
            else {
                return arr;
            }


        }

        public static long factorial(long num) {
            if (num == 1)
            {
                return 1;
            }
            else {
                return num * factorial(num - 1);
            }
        }

        public static void descendingOrder(int[] arr) {
            int lPivot = 0;
            int rPivot = arr.Length - 1;
            int max = 0;
            int maxI = 0;
            while (lPivot != arr.Length) {
                for (int i = rPivot; i >= lPivot; i--) {
                    // find max
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        maxI = i;
                    }
                }
                int tmp = arr[lPivot];
                arr[lPivot] = max;
                arr[maxI] = tmp;
                max = 0;
                maxI = 0;
                lPivot++;
            }
        }


        public static string displayTime()
        {
            int hours = 1;
            int minutes = 0;
            int seconds = 0;

            do
            {
                Console.WriteLine("\nEnter the hour\n");
                hours = int.Parse(Console.ReadLine());
            } while (hours == 0 || hours > 23 || hours < 1);

            do
            {
                Console.WriteLine("\nEnter the minutes\n");
                minutes = int.Parse(Console.ReadLine());
            } while (minutes == 0 || minutes > 59 || minutes < 0);

            do
            {
                Console.WriteLine("\nEnter the seconds\n");
                seconds = int.Parse(Console.ReadLine());

            } while (seconds == 0 || seconds > 59 || seconds < 0);

            return String.Format("\nThe time is : {0}:{1}:{2}\n", hours, minutes, seconds);

        }

        public static int sumArgs(params int[] args) {
            int total = 0;
            for (int i = 0; i < args.Length; i++) {
                total += args[i];
            }
            return total;
        }

        public static string concatStrings(params string[] strings) {
            string concattedString = "";
            for (int i = 0; i < strings.Length; i++) {
                concattedString += strings[i];
            }
            return concattedString;
        }

        public double calculateAverage(params int[] args) {
            double avg = 0.0;
            int total = 0;
            for (int i = 0; i < args.Length; i++) {
                total += args[i];
            }
            return (total * 1.0) / args.Length;
        }

        public static int[] ArrayOfMultiples(int num, int length) {
            int[] arr = new int[length];
            for (int i = 0; i < length; i++) {
                arr[i] = num * (i + 1);
            }
            return arr;
        }

        public int addTwoNumbers(int x = 20, int y = 30) {
            return x + y;
        }

        public static int CounterpartCharCode(char letter) {
            if (Char.ToUpper(letter) == letter)
            {
                letter = Char.ToLower(letter);
                // letter is uppercase
                return ((int)letter);
            }
            else {
                letter = Char.ToUpper(letter);
                return ((int)letter);
            }
        }

        public static double FahrenheitToCelsius(int temp) {
            return (temp - 32) * (5.0 / 9);
        }

        public static string warnTemp(int temp) {
            double degrees = FahrenheitToCelsius(temp);
            switch (degrees > 37) {
                case true:
                        return "You are ill!";
                case false:
                    return String.Format("You body temperature in Celsius degrees is {0}", temp);
                default:
                    return "default";
            }
        }

        public static string printPeriod(int month1, int month2) {

            int period = Math.Abs(month1 - month2);
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(0, "January");
            dict.Add(1, "February");
            dict.Add(2, "March");
            dict.Add(3, "April");
            dict.Add(4, "May");
            dict.Add(5, "June");
            dict.Add(6, "July");
            dict.Add(7, "August");
            dict.Add(8, "September");
            dict.Add(9, "Octomber");
            dict.Add(10, "November");
            dict.Add(11, "December");
            return String.Format("The difference in months between {0} and {1} is : {2}", dict[month1], dict[month2], period);
        }

        public static double getRectangleArea(double width, double height) {
            double area = width * height;
            Console.WriteLine("The area is : {0}",area);
            return area;
        }


        public static bool isArrSymmetric(int[] arr, int len) {
            int middle = len / 2;
            for (int i = 0; i < middle; i++) {
                if (arr[i] == arr[len - (i + 1)])
                {
                    // valid
                    continue;
                }
                else {
                    return false;
                }
            }
            return true;
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
