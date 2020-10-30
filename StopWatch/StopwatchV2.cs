using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopwatchV2
    {
        private DateTime _startTime;
        private DateTime _endTime;
        public ConsoleKeyInfo KeyInfo { get; private set; }

        bool running;
        public StopwatchV2() { }

        public void IsRunning()
        {
            if (running == false)
                Console.WriteLine("Tryk mellemrum for at starte og stoppe stopuret.");

            while (true)
            {
                KeyInfo = Console.ReadKey(true);
                if (KeyInfo.Key.ToString() == "Spacebar")
                {
                    if (running == false)
                    {
                        running = true;
                        Start(DateTime.Now);
                    }

                    if (running == true) // Hvis stopuret køre
                    {
                        running = false;
                        Stop(DateTime.Now);
                    }
                }
            }
        }

        public void Start(DateTime startTime)
        {
            _startTime = startTime;
            Console.WriteLine("\nTimer startet.");
            IsRunning();
        }

        public void Stop(DateTime endTime)
        {
            _endTime = endTime;
            Console.WriteLine("Timer stoppet.\n");
            Console.WriteLine(Duration());
        }

        public TimeSpan Duration()
        {
            return _endTime - _startTime;
        }
    }
}
