using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryPattern.BridgePattern
{
    public interface IPhone
    {
        void MakePhoneCall(string phoneNumber);
        void SendMessage(string phoneNumber, string messgae);
        void ReceivePhoneCall();
        void receiveSMSMessage();
    }
}
