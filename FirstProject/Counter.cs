using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Counter
    {

        public static int counter = 0;

        private Counter(int newCount) {
            counter = newCount;
        }

        private Counter() {
            counter = 0;
        }


        public static void increment() {
            ++counter;
        }

        public static void decrement() {
            --counter;
        }

        public static int getCounter() {
            return counter;
        }

    }
}
