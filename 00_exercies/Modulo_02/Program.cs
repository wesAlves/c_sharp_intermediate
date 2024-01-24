using System;

namespace Modulo_02
{
    internal partial class Program
    {
        public static void Main(string[] args)
        {
            // var working = new Stopwatch();
            //
            // var isRunning = "";
            //
            // Console.Write("Entre com start para inicar o timer: ");
            // isRunning = Console.ReadLine();
            //
            // if (!working.IsRunning)
            // {
            //     var started = working.StartTimer;
            //     
            // }
            //
            //
            // while (isRunning != "stop")
            // {
            //     Console.Write("Timer iniciado Entre com stop para parar o timer: ");
            //     isRunning = Console.ReadLine();
            // }
            //
            // var stoped = working.StopTimer;
            // Console.WriteLine(working.SpentTime);

            var votes = new SackOverFlowPost();

            Console.WriteLine(votes.Votes);
            votes.VoteUp;
            votes.VoteUp;
            votes.VoteUp;
            Console.WriteLine(votes.Votes);
        }
    }
}