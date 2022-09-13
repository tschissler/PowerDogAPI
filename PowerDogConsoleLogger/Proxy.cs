using CookComputing.XmlRpc;

namespace PowerDogConsoleLogger
{
    [XmlRpcUrl("http://192.168.178.150:20000")]
    public class Proxy : XmlRpcClientProtocol
    {
        [XmlRpcMethod("getPowerDogInfo")]
        public Result getPowerDogInfo(string password)
        {
            return (Result)Invoke("getPowerDogInfo", new object[] { password });
        }

        [XmlRpcMethod("getAllCurrentLinearValues")]
        public Result getAllCurrentLinearValues(string password)
        {
            return (Result)Invoke("getAllCurrentLinearValues", new object[] { password });
        }
    }
}