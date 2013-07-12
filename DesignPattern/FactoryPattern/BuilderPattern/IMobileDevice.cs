using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryPattern.BuilderPattern
{
    public interface IMobileDevice
    {
        void SetDateTime();
        void ChangeTimeZone();
        void SetReminderAlert();
        void GetContacts();
        void AddContact();
    }
}
