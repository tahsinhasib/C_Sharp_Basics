using System;
using System.Threading;

namespace ConsoleApp1
{
    class ThreadCreationProgram
    {
        public static void ChildThread()
        {
            Console.WriteLine("Child thread starts");
            // the thread is paused for 5000 milliseconds

            int sleepfor = 5000;

            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }

        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(ChildThread);
            Console.WriteLine("In Main: Creating the Child thread");

            Thread t = new Thread(childref);
            t.Start();

            Console.ReadKey();

            Thread threadA = new Thread(new ThreadStart(ChildThreadA));
            // Create ThreadB object
            Thread threadB = new Thread(new ThreadStart(ChildThreadB));

            threadA.Name = "Thread A"; 
            threadB.Name = "Thread B";

            // set highest priority of threadB

            threadB.Priority = ThreadPriority.Highest;
            threadA.Start();
            threadB.Start(); Thread.CurrentThread.Name = "Main";

            for (int i=0; i<5; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
            }
            Console.ReadKey();
        }
        public static void ChildThreadA()
        {
            for (int i=0; i<3; i++)
            {
                Console.WriteLine("Child thread A:");
            }
        }
        public static void ChildThreadB()
        {
            for (int i=0; i<4; i++)
            {
                Console.WriteLine("Child thread B:");
            }
            Console.ReadKey();
        }
    }


}
