using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryPattern.BridgePattern
{
    public class GenericPhone : Pattern.ITelePhone
    {
        public void MakeCall(string phoneNumber)
        {
            Console.WriteLine("Calling on "+ phoneNumber);
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Phone is ringing");
        }
    }
}
