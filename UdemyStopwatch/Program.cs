using System;

namespace UdemyStopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = new Stopwatch();
            // little menu to display
           string instructions =  
                @"RETE GRAVE STOPWATCH MENU :" + Environment.NewLine +
                "1. Type 'start' to start the counter " + Environment.NewLine +
                "2. Type 'stop' to stop the counter" + Environment.NewLine +
                "3. PROFIT "+ Environment.NewLine +
                "4. Type 'exit' to stop the counter" ;

            Console.WriteLine(instructions);

            while (true)
            {

                string input = Console.ReadLine().ToLower();

                if (input == "start")
                {
                    // start Stopwatch
                    Console.Clear();
                    clock.StartWatch();
                    Console.WriteLine("stopwatch started at " + DateTime.Now);
                }
                else if( input == "stop" )
                {
                    // stop Stopwatch
                    clock.StopWatch();
                    Console.WriteLine(instructions);
                } else if ( input == "stop")
                {
                    Console.WriteLine("CIAO BRO");
                    break;
                }

            } 



        }
    }
}
