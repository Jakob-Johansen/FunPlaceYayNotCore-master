using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class Stopwatch
    {
        public bool running;
        string userText = string.Empty;
        public TimeSpan Duration { get; set; } = new TimeSpan();

        DateTime startTime;
        DateTime endTime;
        public Stopwatch() { }

        public void IsRunning()
        {
            if (running == false)
                Console.WriteLine("Du skal skrive start for at starte og stop for at stoppe.");

            while (true)
            {
                userText = Console.ReadLine();
                userText.ToLower();
                if (userText == "start" || userText == "stop")
                {
                    if (userText == "start" && running == false)
                    {
                        running = true;
                        Start();
                    }

                    if (userText == "stop" && running == true)
                    {
                        running = false;
                        Stop();
                    }
                }
                else
                {
                    Console.WriteLine("Det forstod jeg ikke, prøv igen.");
                }
            }
        }

        public void Start()
        {
            startTime = DateTime.Now;
            Console.WriteLine("Startet");
            IsRunning();
        }

        public void Stop()
        {
            endTime = DateTime.Now;
            Console.WriteLine("Stoppet");
            Duration = endTime - startTime;
            Console.WriteLine(Duration);
        }
    }
}
