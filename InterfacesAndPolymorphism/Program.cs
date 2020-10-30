using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoEncoder = new VideoEncoder();
            videoEncoder.RegisterNotificationChannel(new MailNotificationChannel());
            videoEncoder.RegisterNotificationChannel(new SmsNotificationChannel());
            videoEncoder.Encode(new Video());
        }
    }
}
