using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPattern.FactoryPattern.BuilderPattern;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            //DesignPattern.FactoryPattern.BuilderPattern;
            UseBuilderPattern useBP = new UseBuilderPattern();
            useBP.MakeCallToPerson();

            DesignPattern.FactoryPattern.BridgePattern.ClientUseBridgePattern client = new DesignPattern.FactoryPattern.BridgePattern.ClientUseBridgePattern();
            client.MakePhoneCall("13524343720");
            client.ReceiveCall();
            
            Console.ReadLine();
        }
    }
}
