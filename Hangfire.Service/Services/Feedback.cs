using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangfire.Service.Services
{
    public class Feedback
    {
        [Queue("feedback")]
        public void Send(string delay)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine($"Feedback.Send method called with delay of {delay}");
            Console.WriteLine("Feedback sent");
            Console.WriteLine("**********************************************");
        }
    }
}
