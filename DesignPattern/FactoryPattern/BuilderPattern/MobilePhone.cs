using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryPattern.BuilderPattern
{
    public class MobilePhone : Pattern.ITelePhone, ISMSDevice   
    {
        public void MakeCall(string phoneNumber)
        {
            Console.WriteLine("Calling on " + phoneNumber);
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Receiving call");
        }

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
