using CookComputing.XmlRpc;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerDogConsoleLogger;
using System.Collections.Generic;

namespace XMLRPCTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_getPowerDogInfo()
        {
            Proxy myProxy = new Proxy();
            var result = myProxy.getPowerDogInfo("admin");
            result.ErrorCode.Should().Be(0);
            result.ErrorString.Should().Be("");
            result.Reply["SerialNumber"].Should().Be("PD601-00026");
        }

        [TestMethod]
        public void Test_getAllCurrentLinearValues()
        {
            Proxy myProxy = new Proxy();
            var result = myProxy.getAllCurrentLinearValues("admin");
            result.ErrorCode.Should().Be(0);
            result.ErrorString.Should().Be("");            
            ((XmlRpcStruct)result.Reply[SensorKeys.verbrauchgesamt])["Unit"].Should().Be("W");
        }
    }

    public struct LinearValue
    {
        public string Last_Read_Average;
        public bool Valid;
        public string Last_Usage;
        public string CurrentValue;
        public string Key;
        public string Unit;
        public string Lieferung;
    }
}