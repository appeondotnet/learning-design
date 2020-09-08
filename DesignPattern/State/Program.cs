using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskContext context = new TaskContext();

            context.State = new PendingState();

            context.Start();

            context.Cancel();

            Console.Read();
        }
    }
}
