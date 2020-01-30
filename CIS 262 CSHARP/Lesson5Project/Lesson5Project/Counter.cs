// This does not work in the program and is not referenced by program.cs

// i just left this here to help show the problem i was having.
// it's more or less the same code in program.cs





































using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Lesson5Project
{
    class Counter
    {
        static int aCounter = 0;
        static int bCounter = 0;
        public const int LIMIT = 1000000;

        static ManualResetEvent aCounterStoppedEvent = new ManualResetEvent(false);
        static ManualResetEvent bCounterStoppedEvent = new ManualResetEvent(false);

        public static void ThreadA()
        {
            do
            {
                while (aCounter < LIMIT && !Console.KeyAvailable)
                {
                    aCounter++;
                }
                if (aCounter == LIMIT)
                {
                    Console.WriteLine("Thread A automatically terminated at count limit of " + aCounter);
                    aCounterStoppedEvent.Set();
                    //threadA.Abort();
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            Console.WriteLine("You stopped thread A's counter at: " + aCounter + ".");
            
            aCounterStoppedEvent.Set();
        }

        public static void ThreadB()
        {
            do
            {
                while (bCounter < LIMIT && !Console.KeyAvailable)
                {
                    bCounter++;
                }
                if (bCounter == LIMIT)
                {
                    Console.WriteLine("Thread B automatically terminated at count limit of " + bCounter);
                    bCounterStoppedEvent.Set();
                    //threadB.Abort();
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            Console.WriteLine("You stopped thread B's counter at: " + bCounter + ".");
            bCounterStoppedEvent.Set();
        }

        public static void FinishedCounting()
        {
            aCounterStoppedEvent.WaitOne();
            bCounterStoppedEvent.WaitOne();

            Console.WriteLine("");
            Console.WriteLine("Both counters have stopped. Counter A Stopped at " + aCounter + " while Counter B stopped at " + bCounter + ".");
            Console.ReadLine();
        }
    }
}
