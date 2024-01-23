using System;

namespace Modulo_02
{
    internal partial class Program
    {
        public static void Main(string[] args)
        {
            var working = new Stopwatch();

            var isRunning = "";

            Console.Write("Entre com start para inicar o timer: ");
            isRunning = Console.ReadLine();

            while (isRunning != "start")
            {
                if (!working.IsRunning())
                {
                    working.StartTimer(DateTime.Now);
                }
            }


            while (isRunning != "stop")
            {
                Console.Write("Timer iniciado Entre com stop para parar o timer: ");
                isRunning = Console.ReadLine();
            }

            working.StopTimer(DateTime.Now);
            Console.WriteLine(working.SpentTime());
        }
    }
}