using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndPolymorphism
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send()
        {
            Console.WriteLine("Sending Mail...");
        }
    }
}
