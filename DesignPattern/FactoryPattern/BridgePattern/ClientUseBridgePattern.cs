using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryPattern.BridgePattern
{
    public class ClientUseBridgePattern
    {
        private IPhone userPhone;

        public ClientUseBridgePattern()
        {
            this.userPhone =  new MobilePhone(new GenericPhone(), new GenericSMS());
        }

        public void MakePhoneCall(string phoneNumber)
        {
             userPhone.MakePhoneCall(phoneNumber);
        }
        public void ReceiveCall()
        {
            userPhone.ReceivePhoneCall();
        }
    }
}
