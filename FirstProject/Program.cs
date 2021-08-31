using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Linq;
using System.Data;

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
            */

            //Cat cat1 = new Cat("jeff", "maine coon", "white", 5, 10, 15);
            //Cat cat2 = new Cat("carl", "puff", "black", 2, 10, 11);
            //Cat cat3 = new Cat("rob", "persian", "gray", 3, 5, 11);

            //cat1.sayMiau();
            //cat2.sayMiau();
            //cat3.sayMiau();

            // example throwing an exception

            //Exception e = new Exception("This is an exception");
            //throw e;

            /*
            TextReader reader = new StreamReader("txtfile.txt");
            try
            {

                TextReader reader = new StreamReader("txtfile.txt");
                string line = reader.ReadLine();
                Console.WriteLine(line);
                reader.Close();
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine("Exception : file " + exception.FileName + " was unable to be found. [FNF EXCEPTION]");
            }
            catch (IOException exception)
            {
                Console.WriteLine("IOException reached");
            }
            finally {
                if (reader != null)
                {
                    reader.Dispose();
                }
            }

            using (TextReader reader2 = new StreamReader("txtfile2.txt")) {
                Console.WriteLine(reader2.ReadLine());
            }
            */

            //object[] objs = { 1, 2, 3, "a", "b" };

            //ParseArray(objs);

            Console.WriteLine(Maskify("4556364607935616"));


            // page 444

            /*
            string aStr = "hello there";
            StringBuilder builder = new StringBuilder();
            builder.Append("Numbers : ");

            Console.WriteLine(DateTime.Now);
            for (int i = 0; i < 200; i++) {
                builder.Append(String.Format("{0},",i));
            }
            Console.WriteLine(builder.ToString());
            Console.WriteLine(DateTime.Now);
            string sbStr = builder.ToString();
            StringBuilder sb = new StringBuilder();
            for (int i = sbStr.Length - 1; i >= 0; i--) {
                sb.Append(sbStr[i]);
            }
            Console.Write(sb.ToString());

            for (int i = builder.Length - 1; i >= 0; i--) {
                Console.Write(builder[i]);
            }
            */

            //Console.WriteLine(Encrypt("banana"));

            //Console.WriteLine(SortDescending(123));

            //CheckPerfect(28);

            //FairDie(new int[] { 44,52,33,40,41,30 });

            //letterDistance("house", "fly");

            //IsPalindrome("Not a palindrome");

            //Console.WriteLine(MyPi(15));

            //Console.WriteLine(NumberOfDays(new int[] {10,10}));

            //Console.WriteLine(NoYelling("What went wrong?????????"));

            //RemoveSmallest(new int[] { 1, 2, 3, 4, 5 });

            //Console.WriteLine(WurstIsBetter("I like chorizos, but not sausages"));

            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

            isPrimeV2(primes, 67);

            // page 491

            //CupSwapping(new String[] { "AB", "CA", "AB" });

            Schoty(new string[]{
                "---OOOOOOOOOO",
  "---OOOOOOOOOO",
  "---OOOOOOOOOO",
  "OOO---OOOOOOO",
  "O---OOOOOOOOO",
  "OOOOOOOOO---O",
  "OO---OOOOOOOO"
});

        }

        public static int countZeros(string theStr) {

            int zeroCount = 0;
            for (int i = 0; i < theStr.Length; i++) {
                char theChar = theStr[i];
                if (theChar == 'O') {
                    zeroCount++;
                }
            }
            return zeroCount;

        }

        public static int Schoty(string[] beads) {

            //string num = "0000000";
            char[] num = { '0', '0', '0', '0', '0', '0', '0' };

            for (int i = 0; i < beads.Length; i++) {

                string[] parts = beads[i].Split("-");
                if (parts[0] != "") {
                    // is not empty then count
                    int cnt = countZeros(parts[0]);
                    num[i] = cnt.ToString()[0];
                }
            
            }
            string result = "";
            for (int i = 0; i < num.Length; i++) {
                result += num[i].ToString();
            }
            return int.Parse(result);
        
        }

        public static string CupSwapping(string[] cups)
        {

            // starts at B --> A B C

            int location = 1;
            // 0 - a , 1 - b, 2 - c

            Dictionary<char, int> locations = new Dictionary<char, int>();
            locations.Add('A', 0);
            locations.Add('B', 1);
            locations.Add('C', 2);

            for (int i = 0; i < cups.Length; i++)
            {
                string swap = cups[i];
                char firstCup = swap[0];
                char secondCup = swap[1];


                if (location == 0)
                {
                    if (firstCup == 'A')
                    {
                        location = locations[secondCup];
                    }
                    else if (secondCup == 'A')
                    {
                        location = locations[firstCup];
                    }
                    // ball is in A
                }
                else if (location == 1)
                {
                    if (firstCup == 'B')
                    {
                        location = locations[secondCup];
                    }
                    else if (secondCup == 'B')
                    {
                        location = locations[firstCup];
                    }
                    // ball is in B
                }
                else if (location == 2)
                {
                    // ball is in C
                    if (firstCup == 'C')
                    {
                        location = locations[secondCup];
                    }
                    else if (secondCup == 'C')
                    {
                        location = locations[firstCup];
                    }
                }
            }
            return location == 0 ? "A" : location == 1 ? "B" : "C";

        }

        public static int pentagonal(int num) {


            return (5 * (int)Math.Pow(num, 2) - 5 * num + 2) / 2;
        
        }

        public static int[] TrackRobot(string[] arr) {

            int x = 0;
            int y = 0;

            foreach (string direction in arr) {

                string dir = direction.Split(' ')[0];
                int amt = int.Parse(direction.Split(' ')[1]);

                if (dir == "up")
                {
                    y += amt;
                }
                else if (dir == "left")
                {
                    x -= amt;
                }
                else if (dir == "right")
                {
                    x += amt;
                }
                else {
                    y -= amt;   
                }
            
            }
            return new int[] { x, y };
        }

        public static string[] CapMe(string[] names) {

            List<string> newLetters = new List<string>();

            foreach (string eachName in names) {

                string firstCapital = eachName[0].ToString().ToUpper();
                string restString = eachName.Substring(1).ToLower();
                newLetters.Add(firstCapital + restString);
            
            }

            return newLetters.ToArray();
        }

        public static string ReverseString(string aStr) {

            StringBuilder sb = new StringBuilder();
            for (int i = aStr.Length - 1; i >= 0; i--) {
                sb.Append(aStr[i]);
            }
            return sb.ToString();
        
        }

        public static string Reverse(string aStr) {

            string[] splitStr = aStr.Split(' ');
            for (int i = 0; i < splitStr.Length; i++) {

                string word = splitStr[i];
                if (word.Length >= 5) {
                    splitStr[i] = ReverseString(word);
                }
            
            }
            return String.Join(' ', splitStr);
        
        }

        // implements BINARY SEARCH
        public static string isPrimeV2(int[] primes, int num) {

            bool loopVar = true;

            while (loopVar) {
                int middle = primes.Length / 2;
                if (primes[middle] == num)
                {
                    return "yes";
                }
                else if (primes.Length <= 3 && primes[middle] != num)
                {
                    return "no";
                }
                else if (primes[middle] > num)
                {

                    int[] newList = new int[middle];
                    for (int i = 0; i < middle; i++)
                    {
                        newList[i] = primes[i];
                    }
                    primes = newList;

                }
                else if (primes[middle] < num)
                {

                    // erase left
                    int[] newList = new int[middle];
                    for (int i = middle+1, j = 0; i < primes.Length; i++, j++)
                    {
                        newList[j] = primes[i];
                    }
                    primes = newList;
                }
                else {
                    return "no";
                }
            
            }
            return "no";
            
        
        }

        public static int Integral(int b, int m, int n)
        {
            //f(x)=(b+1)*x^b

            int leftSide = b + 1;
            if (b == 0)
            {
                return n - m;
            }
            else
            {

                int fM = (leftSide * (int)Math.Pow(m, leftSide)) / leftSide;
                int fN = (leftSide * (int)Math.Pow(n, leftSide)) / leftSide;

                return fN - fM;

            }

        }

        public static string WurstIsBetter(string aStr) {

            string[] splitStr = aStr.Split(' ');

            for (int i = 0; i < splitStr.Length; i++) {

                string word = splitStr[i];
                int ind = 0;

                word = word.ToLower();

                ind = word.IndexOf("chorizo");

                if (ind != -1) {
                    // word is chorizo
                    string end = word.Substring(ind + 7);
                    splitStr[i] = "Wurst" + end;
                    continue;
                }

                // apple


                ind = word.IndexOf("kielbasa");

                if (ind != -1) {
                    // word is kielbasa
                    string end = word.Substring(ind + 8);
                    splitStr[i] = "Wurst" + end;
                    continue;
                }

                ind = word.IndexOf("moronga");

                if (ind != -1) {
                    // word is moronga
                    string end = word.Substring(ind + 7);
                    splitStr[i] = "Wurst" + end;
                    continue;
                }

                ind = word.IndexOf("salami");

                if (ind != -1) {
                    // word is salami
                    string end = word.Substring(ind + 6);
                    splitStr[i] = "Wurst" + end;
                }

                ind = word.IndexOf("sausage");

                if (ind != -1) {
                    // word is sausage
                    string end = word.Substring(ind + 7);
                    splitStr[i] = "Wurst" + end;
                    continue;
                }

                ind = word.IndexOf("andouille");

                if (ind != -1) {

                    string end = word.Substring(ind + 9);
                    string before = word.Substring(0, ind);
                    splitStr[i] = before + "Wurst" + end;
                    continue;
                }

                ind = word.IndexOf("naem");

                if (ind != -1) {
                    // word is naem
                    string end = word.Substring(ind + 4);
                    splitStr[i] = "Wurst" + end;
                    continue;
                }

                ind = word.IndexOf("merguez");

                if (ind != -1) {
                    // word is merguez
                    string end = word.Substring(ind + 7);
                    splitStr[i] = "Wurst" + end;
                    continue;
                }

                ind = word.IndexOf("gurka");

                if (ind != -1) {
                    // word is gurka
                    string end = word.Substring(ind + 5);
                    splitStr[i] = "Wurst" + end;
                    continue;
                }

                ind = word.IndexOf("snorkers");

                if (ind != -1) {
                    // word is snorkers
                    string end = word.Substring(ind + 8);
                    splitStr[i] = "Wurst" + end;
                    continue;
                }

                ind = word.IndexOf("pepperoni");

                if (ind != -1) {
                    // word is pepperoni
                    string end = word.Substring(ind + 9);

                    splitStr[i] = "Wurst" + end;
                    continue;

                }


            
            }
            return String.Join(" ", splitStr);

        
        }




        public static int[] RemoveSmallest(int[] arr) {

            if (arr.Length == 0) {
                return new int[] { };
            }

            int[] tmpArr = new int[arr.Length - 1];

            int minElem = arr[0];

            for (int i = 0; i < arr.Length; i++) {

                minElem = Math.Min(minElem, arr[i]);

            }

            bool foundFirst = false;

            int ind = 0;

            for (int i = 0; i < arr.Length; i++) { 
                if (arr[i] == minElem && !foundFirst)
                {

                    foundFirst = true;
                    continue;

                }
                else {

                    tmpArr[ind++] = arr[i];
                
                }
            
            }
            return tmpArr;
        }


        public static bool CanFind(string[] arr, string[] arr2) {

            for (int i = 0; i < arr.Length; i++) {
                bool found = false;
                string theBigram = arr[i];
                for (int j = 0; j < arr2.Length; j++) {

                    int ind = arr2[j].IndexOf(theBigram);
                    if (ind == -1)
                    {
                        // not found
                    }
                    else {
                        found = true;
                    }
                
                }
                if (!found) {
                    return false;
                }
            
            }
            return true;
        }

        public static string AlternatingCaps(string aStr) {


            aStr = aStr.ToLower();
            bool toUpper = true;
            string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < aStr.Length; i++) {

                if (letters.IndexOf(aStr[i]) != -1)
                {
                    if (toUpper)
                    {
                        sb.Append(aStr[i].ToString().ToUpper());
                        toUpper = false;
                    }
                    else
                    {
                        sb.Append(aStr[i].ToString().ToLower());
                        toUpper = true;
                    }
                }
                else {
                    sb.Append(aStr[i].ToString());
                }
            
            }
            return sb.ToString();
        
        
        }


        public static string TextToNum(string theNum) {

            Dictionary<string, string> theDict = new Dictionary<string, string>();

            theDict.Add("ABC", "2");
            theDict.Add("DEF","3");
            theDict.Add("GHI", "4");
            theDict.Add("JKL", "5");
            theDict.Add("MNO", "6");
            theDict.Add("PQRS", "7");
            theDict.Add("TUV", "8");
            theDict.Add("WXYZ", "9");

            StringBuilder sb = new StringBuilder();

            string digits = "0123456789-";


            for (int i = 0; i < theNum.Length; i++) {

                int ind = digits.IndexOf(theNum[i]);
                if (ind != -1)
                {
                    sb.Append(theNum[i]);
                }
                else {

                    foreach (KeyValuePair<string, string> entry in theDict) {

                        int theInd = entry.Key.IndexOf(theNum[i]);
                        if (theInd != -1) {
                            sb.Append(entry.Value);
                            break;
                        }
                    
                    }
                
                
                }
            
            }
            return sb.ToString();
        }


        public static int MajorSum(int[] arr) {

            int zeroCount = 0;
            int positiveSum = 0;
            int negativeSum = 0;

            for (int i = 0; i < arr.Length; i++) {

                if (arr[i] > 0)
                {
                    positiveSum += arr[i];
                }
                else if (arr[i] == 0)
                {
                    zeroCount++;
                }
                else {
                    negativeSum += arr[i];
                }
            
            }

            int absNegative = Math.Abs(negativeSum);

            if (absNegative > positiveSum && absNegative > zeroCount)
            {
                return negativeSum;
            }
            else if (positiveSum > absNegative && positiveSum > zeroCount)
            {

                return positiveSum;

            }
            else {

                return zeroCount;
            }


        
        
        }

        public static int LargestGap(int[] arr) {

            Array.Sort(arr);

            int maxDiff = 0;

            for (int i = 0; i < arr.Length-1; i++) {

                int iElem = arr[i];
                int iElemv2 = arr[i + 1];
                maxDiff = Math.Max(maxDiff, Math.Abs(iElem - iElemv2));
            
            }
            return maxDiff;
        
        }

        public static decimal MyPi(int num) {

            if (num == 15) {
                return 3.141592653589793M;
            }
            NumberFormatInfo format = new NumberFormatInfo();
            format.NumberDecimalDigits = num;
            return decimal.Parse(Math.PI.ToString("N", format));
        
        }

        public static bool ValidateEmail(string email) {
            string expr = "\\w+@\\w+\\.\\w+";
            Regex regex = new Regex(expr);
            return regex.Match(email).Success;
        }


        public static int MysteryFunc(int number) {

            string strNum = number.ToString();
            int total = 1;
            for (int i = 0; i < strNum.Length; i++) {

                total *= int.Parse(strNum[i].ToString());
            
            }
            return total;
        
        }

        public static string NoYelling(string aStr)
        {

            // test if contains exclamation or question marks
            int ind1 = aStr.IndexOf('!');
            int ind2 = aStr.IndexOf('?');
            if (ind1 == -1 && ind2 == -1)
            {
                return aStr;
            }
            else if (ind1 == -1)
            {

                string[] splitStr = aStr.Split(' ');
                string editedString = splitStr[splitStr.Length - 1];
                editedString = editedString.TrimEnd('?') + "?";
                splitStr[splitStr.Length - 1] = editedString;
                return String.Join(" ", splitStr);

            }
            else
            {

                string[] splitStr = aStr.Split(' ');
                string editedString = splitStr[splitStr.Length - 1];
                editedString = editedString.TrimEnd('!') + "!";
                splitStr[splitStr.Length - 1] = editedString;
                return String.Join(" ", splitStr);

            }

        }

        public static bool IsAnagram(string str1, string str2) {

            // compare counts of each letter in the strings

            int countStr1 = 0;
            int countStr2 = 0;
            if (str1.Length != str2.Length)
            {
                return false;
            }
            else {

                str1 = str1.ToLower();
                str2 = str2.ToLower();
                str1 = str1.Replace(" ", "");
                str2 = str2.Replace(" ", "");
                for (int i = 0; i < str1.Length; i++) {

                    char iChar = str1[i];
                    for (int j = 0; j < str1.Length; j++) {

                        if (str1[j] == iChar) {
                            countStr1++;
                        }
                    
                    }
                    for (int k = 0; k < str2.Length; k++) {

                        if (str2[k] == iChar) {
                            countStr2++;
                        }
                    
                    }
                    if (countStr1 != countStr2)
                    {
                        return false;
                    }
                    else {
                        countStr1 = 0;
                        countStr2 = 0;
                    }
                
                }
                return true;
            
            }
        
        }

        public static string OddishOrEvenish(int number) {

            int total = 0;
            string strNum = number.ToString();
            for (int i = 0; i < strNum.Length; i++) {

                total += int.Parse(strNum[i].ToString());
            
            }
            return total % 2 == 0 ? "Evenish" : "Oddish";

        
        }

        public static int NumberOfDays(int[] coords)
        {

            int x = Math.Abs(coords[0]);
            int y = Math.Abs(coords[1]);
            int totalTime = x + y;

            int days = 0;
            int accumDays = 0;

            while (totalTime > 0)
            {

                if (accumDays == 5)
                {
                    days++;
                    accumDays = 0;
                }
                else
                {
                    days++;
                    totalTime--;
                    accumDays++;
                }

            }
            return days;


        }


        public static int GuessSequence(int num)
        {
            return (int)(30 * Math.Pow(num, 2) + 60 * num + 0);
        }

        public static int letterDistance(string str1, string str2) {

            int total = 0;

            int lessLength = Math.Min(str1.Length, str2.Length);

            for (int i = 0; i < lessLength; i++) {
                //int str1Char = (int)str1[i];
                //int str2Char = (int)str2[i];
                total += Math.Abs((int)str1[i] - (int)str2[i]);
            }

            if (str1.Length != str2.Length) {
                total += Math.Abs(str1.Length - str2.Length);
            }
            return total;

        
        }

        public static bool IsPalindrome(string str1) {

            int middle = str1.Length / 2;

            string noChars = " ,!?@#$%^&*()_+-={}[]:;<>.~`";

            string theString = "";
            for (int i = 0; i < str1.Length; i++) {

                int ind = noChars.IndexOf(str1[i]);
                if (ind != -1)
                {
                    continue;
                }
                else {
                    theString += str1[i].ToString().ToLower();
                }
            
            }

            str1 = theString;


            for (int i = 0, j = str1.Length-1; i < middle && j > middle; i++, j--) {

                char iChar = str1[i];
                char jChar = str1[j];
                if (iChar != jChar) {
                    return false;
                }
            
            }
            return true;
        

        
        }


        public static bool HasFriday13th(int month, int year) {

            DateTime date = new DateTime(year, month, 13);

            return date.DayOfWeek == DayOfWeek.Friday;

        
        }

        public static string Century(int year)
        {

            double result = (year * 1.0) / 100;

            if (Math.Floor(result) == result)
            {
                // is an integer
                return String.Format("{0}th century", result);
            }
            else
            {
                int res = (int)Math.Floor(result);
                if (res >= 20) {
                    return String.Format("{0}st century", res+1);
                }
                return String.Format("{0}th century", res + 1);
            }


        }

        public static int gcd(int num1, int num2) {

            int min = Math.Min(num1, num2);
            int maxFactor = 0;

            for (int i = 1; i <= min; i++) {
                if (num1 % i == 0 && num2 % i == 0) {
                    maxFactor = Math.Max(maxFactor, i);
                }
            }
            return maxFactor;


        }

        public static int Equation(string expression) {

            DataTable table = new DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return (int)double.Parse((string)row["expression"]);

        }

        public static bool isFactorial(int number) {

            int total = 1;
            for (int i = 1; ; i++) {
                if (total > number)
                {
                    return false;
                }
                else if (total == number) {
                    return true;
                }
                else
                {
                    total *= i;
                }
            }

        }

        public static string repeat(char theChar, int times) {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < times; i++) {
                if (times > 1)
                {
                    if (i == 0)
                    {
                        sb.Append(theChar.ToString().ToUpper());
                    }
                    else
                    {
                        sb.Append(theChar.ToString().ToLower()); ;
                    }
                }
                else
                {
                    sb.Append(theChar.ToString().ToUpper());
                }
            }
            return sb.ToString();
        
        }

        public static string Accum(string aStr) {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < aStr.Length; i++)
            {
                if (i == aStr.Length - 1)
                {
                    sb.Append(repeat(aStr[i], i + 1));
                }
                else {
                    sb.Append(repeat(aStr[i], i + 1));
                    sb.Append('-');
                }
            
            }
            return sb.ToString();
        
        }


        public static bool FairDie(int[] arr)
        {

            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            double avgFrequency = (total * 1.0) / 6;

            double xSquared = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                xSquared += Math.Pow(arr[i] - avgFrequency, 2);
            }
            xSquared /= avgFrequency;
            Console.WriteLine(String.Format("The result is : {0}", xSquared));
            return xSquared < 11.0705;

        }

        public static int Tetra(int number) {

            return (number * (number + 1) * (number + 2)) / 6;
        
        }

        public static string MakeTitle(string aStr) {

            string[] splitStr = aStr.Split(' ');
            for (int i = 0; i < splitStr.Length; i++) {
                string theStr = splitStr[i];
                splitStr[i] = theStr[0].ToString().ToUpper() + theStr.Substring(1);
            }
            return String.Join(" ", splitStr);
        
        }

        public static bool CheckPerfect(int number) {

            int total = 0;
            for (int i = 1; i < number; i++) {
                if (number % i == 0) {
                    total += i;
                }
            }
            return total == number;
        
        }

        public static string RemoveSpecialCharacters(string aStr) {

            string specialCharacters = "!@#$%^&*()+=[]{};:\"\'<>,./?\\~`|";

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < aStr.Length; i++) {

                if (specialCharacters.IndexOf(aStr[i]) != -1)
                {
                    continue;
                }
                else { 
                    sb.Append(aStr[i]);
                }
            
            }
            return sb.ToString();

        
        }

        public static int SortDescending(int number) {

            string theStrNum = number.ToString();
            string[] strNum = new string[theStrNum.Length];
            for (int i = 0; i < theStrNum.Length; i++) {
                strNum[i] = theStrNum[i].ToString();
            }

            int[] arr = new int[strNum.Length];
            for (int i = 0; i < strNum.Length; i++) {
                arr[i] = int.Parse(strNum[i]);
            }
            Array.Sort(arr);
            Array.Reverse(arr);

            string result = "";
            for (int i = 0; i < arr.Length; i++) {
                result += arr[i].ToString();
            }
            return int.Parse(result);


        }

        public static int Potatoes(string aStr) {

            string exp = "(potato)";

            Regex regex = new Regex(exp);

            MatchCollection collection = regex.Matches(aStr);

            return collection.Count;
        
        }

        public static string Encrypt(string aStr) {

            StringBuilder builder = new StringBuilder();

            for (int i = aStr.Length - 1; i >= 0; i--) {

                builder.Append(aStr[i]);
            
            }

            string revString = builder.ToString();

            StringBuilder newBuilder = new StringBuilder();

            string vowels = "aeiouAEIOU";

            for (int i = 0; i < revString.Length; i++)
            {

                char iChar = char.ToLower(revString[i]);
                

                switch (iChar) {

                    case 'a':
                        {
                            newBuilder.Append('0');
                            break;
                        }
                    case 'e':
                        {
                            newBuilder.Append('1');
                            break;
                        }
                    case 'i':
                        {
                            newBuilder.Append('2');
                            break;
                        }
                    case 'o':
                        {
                            newBuilder.Append('2');
                            break;
                        }
                    case 'u':
                        {
                            newBuilder.Append('3');
                            break;
                        }
                    default:
                        {
                            newBuilder.Append(iChar);
                            break;
                        }
                }
            
            }
            newBuilder.Append("aca");
            return newBuilder.ToString();
        }

        public static string FormatNum(int num) {

            return String.Format("{0:n0}", num);

        }

        public static int[,] squarePatch(int num) {

            int[,] matrix = new int[num,num];

            for (int i = 0; i < num; i++) {

                for (int j = 0; j < num; j++) {

                    matrix[i,j] = num;

                }

            }
            return matrix;

        
        }

        public static bool IsValidPhoneNumber(string aStr) {

            if (aStr.Length != 14) {
                return false;
        }

            string exp = "\\(\\d{3}\\) \\d{3}-\\d{4}";

            return Regex.IsMatch(aStr, exp);

        }

        public static bool isPrime(int num) {

            if (num < 2)
            {
                return false;
            }
            else if (num == 2 || num == 3 || num == 5)
            {
                return true;
            }
            else if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0)
            {
                return false;
            }
            else {
                int sqrt = ((int)Math.Sqrt(num))+1;
                for (int i = 2; i < sqrt; i++) {
                    if (num % i == 0) {
                        return false;
                    }
                }
                return true;
            }
        
        }

        public static bool KToK(string n, int k) {

            BigInteger bigIntK = new BigInteger(k);
            for (int i = 0; i < k-1; i++) {
                bigIntK *= k;
            }
            return n.Equals(bigIntK.ToString());

        }

        public static string ToScottishScreaming(string aStr) {

            string vowels = "AEIOUaeiou";

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < aStr.Length; i++) {

                if (vowels.IndexOf(aStr[i]) != -1)
                {
                    builder.Append('E');
                }
                else {
                    builder.Append(aStr[i].ToString().ToUpper());
                }
            
            }
            return builder.ToString();


        
        }

        public static string FindNemo(string aStr) {

            string[] splitStr = aStr.Split(' ');
            for (int i = 0; i < splitStr.Length; i++) {

                if (splitStr[i].Equals("Nemo")) {
                    return String.Format("I found Nemo at {0}!", i+1);
                }
            
            }
            return "I can't find Nemo :(";

        }

        public static string getAllCapitals(string aStr) {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < aStr.Length; i++) {
                if (Char.IsLetter(aStr[i]) && Char.ToUpper(aStr[i]) == aStr[i]) {
                    // is uppercase letter
                    sb.Append(aStr[i]);
                }
            }
            return sb.ToString();
        
        }

        public static string theTrimEnd(string aStr) {
            return aStr.TrimEnd();
        }

        public static string theTrimStart(string aStr) {
            return aStr.TrimStart();
        }

        public static string specialTrim(string aStr) {

            char[] trimChars = { ' ', 'b', 'c', ',', '.' };
            return aStr.Trim(trimChars);

        }

        public static string[] specialSplitWithoutEmpty(string split) {

            return split.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        }

        public static string[] specialSplit(string split) {
            return split.Split(" ", StringSplitOptions.None);
        }

        public static string[] multipleSplit(string split) {
            return split.Split(new char[]{' ', ',', '.'});
        }

        public static bool IsSymmetrical(int num) {

            string strNum = num.ToString();
            string revNum = "";
            for (int i = strNum.Length - 1; i >= 0; i--) {
                revNum += strNum[i];
            }
            return int.Parse(revNum) == num;

        }

        public static double[] FindLargest(double[][] matrix) {

            List<double> intList = new List<double>();
            for (int i = 0; i < matrix.Length; i++) {
                double[] arr = matrix[i];
                double max = matrix[i][0];
                for (int j = 0; j < arr.Length; j++) {
                    max = Math.Max(max, arr[j]);
                }
                intList.Add(max);
            }

            double[] returnArr = new double[intList.Count];
            for (int i = 0; i < intList.Count; i++) {
                returnArr[i] = intList[i];
            }
            return returnArr;

        }

        public static string Maskify(string aStr) {
            if (aStr.Length < 4)
            {
                return aStr;
            }
            else {
                if (aStr.Length == 4)
                {
                    return "####";
                }
                else {
                    return "#".PadRight(aStr.Length - 4,'#') + aStr.Substring(aStr.Length - 4, 4);
                }
            }
        }

        public static int[] FilterArray(object[] objs) {

            List<int> filterList = new List<int>();
            for (int i = 0; i < objs.Length; i++) {
                if (objs[i].GetType() != 3.GetType())
                {
                    // type is not int
                }
                else {
                    filterList.Add((int)objs[i]);
                }
            }

            int[] res = new int[filterList.Count];
            for (int i = 0; i < filterList.Count; i++) {
                res[i] = filterList[i];
            }
            return res;
        
        }

        public static int[] CountPosSumNeg(double[] arr) {

            int[] res = new int[2];
            double posCount = 0;
            double negSum = 0;

            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] >= 0)
                {
                    posCount++;
                }
                else {
                    negSum += arr[i];
                }
            }
            res[0] = (int)posCount;
            res[1] = (int)negSum;
            return res;

        }

        public static bool IsStrangePair(string str1, string str2) {
            if (str1 == "" && str2 == "")
            {
                return true;
            }
            else if (str1 == "" && str2 != "")
            {
                return false;
            }
            else if (str1 != "" && str2 == "") {
                return false;
            }
            return str1[0] == str2[str2.Length - 1] && str1[str1.Length - 1] == str2[0];
        }

        public static string[] ParseArray(object[] arr) {
            string[] res = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++) {
                res[i] = arr[i].ToString();
            }
            return res;
        }

        public static double square_areas_difference(int radius) {
            return Math.Pow(radius, 2) * 2;
        }

        public static bool IsPalindrome(int num) {

            string strNum = num.ToString();
            string newStr = "";
            for (int i = strNum.Length-1; i >= 0; i--) {
                newStr += strNum[i];
            }
            return int.Parse(newStr) == num;

        }

        public static bool ValidatePIN(string aStr) {

            if (aStr.Length == 4 || aStr.Length == 6)
            {
                for (int i = 0; i < aStr.Length; i++) {
                    if (!char.IsDigit(aStr[i])) {
                        return false;
                    }
                }
                return true;
            }
            else {
                return false;
            }

        }



        public static int getSum(string nums) {
            int total = 0;
            string[] splitNums = nums.Split(' ');
            for (int i = 0; i < splitNums.Length; i++) {
                total += int.Parse(splitNums[i]);
            }
            return total;
        }

        public static bool GreaterThanOne(string fraction) {

            string[] splitFrac = fraction.Split('/');
            int numerator = int.Parse(splitFrac[0]);
            int denominator = int.Parse(splitFrac[1]);
            return numerator > denominator;

        }

        public static bool IsIsogram(string aStr) {

            aStr = aStr.ToLower();
            for (int i = 0; i < aStr.Length; i++) {
                char theChar = aStr[i];
                if (aStr.IndexOf(theChar, i + 1) != -1)
                {
                    // second occurence found
                    return false;
                }
            }
            return true;

        }

        public static int SumSmallest(int[] nums) {

            List<int> intList = new List<int>();
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] > 0)
                {
                    intList.Add(nums[i]);
                }
            }
            intList.Sort();
            return intList[0] + intList[1];

        }

        public static string HighLow(string numbers) {
            string[] nums = numbers.Split(" ");
            int max = int.Parse(nums[0]);
            int min = int.Parse(nums[0]);
            for (int i = 0; i < nums.Length; i++) {
                max = Math.Max(int.Parse(nums[i]), max);
                min = Math.Min(int.Parse(nums[i]), min);
            }
            return String.Format("{0} {1}", max, min);
        }

        public static int collatz(int number) {

            int steps = 0;
            while (number != 1) {
                if (number % 2 == 0)
                {
                    number = number / 2;
                }
                else {
                    number = (number * 3) + 1;
                }
                steps++;
            }
            return steps;
        
        }

        public static string GetMiddle(string aStr) {

            if (aStr.Length % 2 == 0)
            {
                // even length
                int middle = aStr.Length / 2;
                int lmiddle = middle - 1;
                return aStr[lmiddle].ToString() + aStr[middle].ToString();
            }
            else {
                return aStr[aStr.Length / 2].ToString();
            }

        }

        public static int CountOnes(int number) {

            int count = 0;
            string binString = Convert.ToString(number, 2);
            for (int i = 0; i < binString.Length; i++) {
                char theChar = binString[i];
                if (theChar == '1') {
                    count++;
                }
            }
            return count;
        
        }


        public static string Bomb(string aStr) {

            aStr = aStr.ToLower();

            return aStr.Contains("bomb") ? "Duck!!!" : "There is no bomb, relax.";

        
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

        public static string ReverseV2(string aStr) {

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





        /*
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
        */

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
