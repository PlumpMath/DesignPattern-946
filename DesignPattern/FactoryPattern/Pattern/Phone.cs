using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryPattern.Pattern
{
    public class Phone : ITelePhone
    {
        public void MakeCall(string phoneNumber)
        {
            Console.WriteLine("Calling ...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Phone is ringing");
        }
    }
}
