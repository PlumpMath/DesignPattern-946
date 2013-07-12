using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryPattern.BridgePattern
{
    public class GenericSMS : BuilderPattern.ISMSDevice 
    {
        public void SendSMS(string phoneNumber, string Message)
        {
            Console.WriteLine("Send SMS");
        }

        public void ReceiveSMS()
        {
            Console.WriteLine("Receive SMS");
        }
    }
}
