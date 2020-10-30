using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndPolymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannel;

        public VideoEncoder()
        {
            _notificationChannel = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            foreach (var cannel in _notificationChannel)
            {
                cannel.Send();
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannel.Add(channel);
        }
    }
}
