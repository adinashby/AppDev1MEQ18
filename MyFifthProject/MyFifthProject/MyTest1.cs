//using System;
//using System.Threading;
//namespace MyFifthProject
//{
//    public class MyTest1
//    {
//        public static void Main(String[] args)
//        {


//            Enumerable.Range(0, 100).ToList().ForEach(f =>
//            {
//                //    //new Thread(() =>
//                //    //{
//                //    //    Console.WriteLine($"Thread Number: {Thread.CurrentThread.ManagedThreadId} started");
//                //    //    Thread.Sleep(1000);
//                //    //    Console.WriteLine($"Thread Number: {Thread.CurrentThread.ManagedThreadId} ended");
//                //    //}).Start();

//                ThreadPool.QueueUserWorkItem(ThreadProc);

//                Console.WriteLine($"Thread Number: {Thread.CurrentThread.ManagedThreadId} started");
//                Thread.Sleep(1000);
//                Console.WriteLine($"Thread Number: {Thread.CurrentThread.ManagedThreadId} ended");
//            });

//            //Enumerable.Range(0, 100).ToList().ForEach(f =>
//            //{
//            //    // Queue the task.
//            //    ThreadPool.QueueUserWorkItem(ThreadProc);
//            //    Console.WriteLine("Main thread does some work, then sleeps.");
//            //    Thread.Sleep(1000);

//            //    Console.WriteLine("Main thread exits.");
//            //});
//        }

//        // This thread procedure performs the task.
//        static void ThreadProc(Object stateInfo)
//        {
//            // No state object was passed to QueueUserWorkItem, so stateInfo is null.
//            Console.WriteLine("Hello from the thread pool.");
//        }
//    }

//}

