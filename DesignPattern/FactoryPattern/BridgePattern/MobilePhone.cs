using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryPattern.BridgePattern
{
    /// <summary>
    /// This class provide a brige and completly depends on GenericPhone and GenericSMS classes
    /// If some changes are come from user then dev need to do those changes in GenericPhone and GenericSMS classes
    /// without touch this brige pattern
    /// </summary>
    public class MobilePhone : IPhone
    {
        private GenericPhone phone;
        private GenericSMS smsDevice;

        public MobilePhone(GenericPhone phone, GenericSMS sms)
        {
            this.phone = phone;
            this.smsDevice = sms;
        }

        public void MakePhoneCall(string phoneNumber)
        {
            this.phone.MakeCall(phoneNumber);
        }

        public void SendMessage(string phoneNumber, string messgae)
        {
            this.smsDevice.SendSMS(phoneNumber, messgae);
        }


        public void ReceivePhoneCall()
        {
            this.phone.ReceiveCall();
        }

        public void receiveSMSMessage()
        {
            this.smsDevice.ReceiveSMS();
        }
    }
}
