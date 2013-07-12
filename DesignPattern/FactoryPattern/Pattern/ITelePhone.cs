using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryPattern.Pattern
{
    public interface ITelePhone
    {
        void MakeCall(string phoneNumber);
        void ReceiveCall();
    }
}
