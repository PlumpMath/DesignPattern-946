using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryPattern.AdapterPattern
{
    public class Laptop
    {
        public void OpenVoiceSocket()
        {
            Console.WriteLine("Open voice socket in laptop ...");
        }

        public void SendVoiceData()
        {
            Console.WriteLine("Voice date send ...");
        }
    }

}
