using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9.Question_3
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"A message was sent to you by {recipient} using Push Notification Service");
            Console.WriteLine($"Its content : {message}");
        }
    }
}
