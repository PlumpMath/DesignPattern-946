using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryPattern.AdapterPattern
{
    /// <summary>
    /// Adaptor pattern is nothing but just do the adaption existing pattern in other device
    /// Here we have an existing mobile pattern i.e basically do the call so adaption is nothing but do the call by using laptop;
    /// As we know laptop hardware is different than mobile so we have to provide a complete different implementation
    /// </summary>
    public class LaptopAdaptor : Pattern.ITelePhone
    {
        private Laptop computer1 = new Laptop();
        
        public void MakeCall(string phoneNumber)
        {
            computer1.OpenVoiceSocket();
            computer1.SendVoiceData();

            Console.WriteLine("Calling on " + phoneNumber + " from laptop");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Receive call ...");
        }
    }
}
