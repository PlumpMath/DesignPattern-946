using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryPattern.BuilderPattern
{
    public interface ISMSDevice
    {
        void SendSMS(string phoneNumber, string Message);
        void ReceiveSMS();
    }
}
