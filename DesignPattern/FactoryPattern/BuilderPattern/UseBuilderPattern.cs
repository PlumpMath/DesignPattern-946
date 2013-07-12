using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryPattern.BuilderPattern
{
    public class PhoneService
    {
        public void CallNumber(Pattern.ITelePhone device, string phoneNumber)
        {
            device.MakeCall(phoneNumber);
        }
    }
    public class UseBuilderPattern
    {
        public void MakeCallToPerson()
        {
            PhoneService ps = new PhoneService();
            Pattern.ITelePhone phone = new MobilePhone();
            ps.CallNumber(phone, "13524343720");
        }
    }
}
