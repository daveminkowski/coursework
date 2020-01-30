/***********************************************************************************************
Name:			David Minkowski
Course:			CIS 262AD - Summer 2018 - Class: 11766
Assignment:		Lesson 5 Project
Date:			06/23/2018
Description:	This program begins 2 threads which count until the user presses enter, then
                displays the count for each thread.
************************************************************************************************/

// So, my issue here was wanting to provide for the eventuality that a user might let the program reach the counter limit, which is currently set at 1,000,000.
// I wanted the threads to auto terminate when they reached the limit and give a notification that they'd done so, but when I called the counter methods from their class, I couldn't divine a way to 
// call the abort() method to prematurely end the counting threads unless it was written this way. As I'm writing this I realized I can leave out the manualresetevents and simply add a 
// thread.join() to the finishedCounting method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Lesson5Project
{
    class Program
    {
        const int LIMIT = 100005;
        static int aCounter = 0;
        static int bCounter = 0;

        static ManualResetEvent aCounterStoppedEvent = new ManualResetEvent(false);
        static ManualResetEvent bCounterStoppedEvent = new ManualResetEvent(false);

        static System.Threading.Thread threadA = new Thread(ThreadA);           // allows methods to reference abort
        static System.Threading.Thread threadB = new Thread(ThreadB);
        static System.Threading.Thread threadC = new Thread(FinishedCounting);

        static void Main(string[] args)
        {
            Console.WriteLine("When you're ready, this program starts two threads which will each begin to count to 1 million.");
            Console.WriteLine("Press 'enter' to start the count for both threads, then press enter to stop each of the counting threads.");
            Console.WriteLine("");
            Console.WriteLine("Counter A initialized at: " + aCounter + ". Counter B initialized at: " + bCounter);
            Console.WriteLine("");
            Console.WriteLine("Press 'enter' to begin...");
            Console.ReadLine();
            Console.WriteLine("Beginning Count...");

            // Create the threads here in main
            //Thread threadA = new Thread(ThreadA);                                         //doesn't allow for abort called in methods when all method's access modifiers are public
            //Thread threadB = new Thread(ThreadA);
            //Thread threadC = new Thread(ThreadA);

            // create threads from Counter Class
            //Thread threadA = new Thread(new ThreadStart(Counter.ThreadA));                also does not allow for abort to be called in methods, even while public
            //Thread threadB = new Thread(new ThreadStart(Counter.ThreadB));
            //Thread threadC = new Thread(new ThreadStart(Counter.FinishedCounting));

            threadA.Start();
            threadB.Start();
            threadC.Start();

        }

        static void ThreadA() // must be a static member to call abort?
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
                    threadA.Abort();
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            Console.WriteLine("You stopped the counter at: " + aCounter);
            aCounterStoppedEvent.Set();
        }

        static void ThreadB()
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
                    threadB.Abort();
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            Console.WriteLine("You stopped the counter at: " + bCounter);
            bCounterStoppedEvent.Set();
        }

        static void FinishedCounting()
        {
            aCounterStoppedEvent.WaitOne();
            bCounterStoppedEvent.WaitOne();
            //threadA.Join(); 
            //threadB.Join();

            Console.WriteLine("");
            Console.WriteLine("Both counters have stopped. Counter A Stopped at " + aCounter + " while Counter B stopped at " + bCounter + ".");
            Console.ReadLine();
        }

    }
}
