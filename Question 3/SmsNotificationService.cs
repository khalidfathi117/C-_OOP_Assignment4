using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9.Question_3
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"A message was sent to you by {recipient} using SMS");
            Console.WriteLine($"Its content : {message}");
        }
    }
}
