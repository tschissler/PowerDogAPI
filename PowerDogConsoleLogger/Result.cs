using CookComputing.XmlRpc;

namespace PowerDogConsoleLogger
{
    public struct Result
    {
        public string ErrorString;
        public XmlRpcStruct Reply;
        public int ErrorCode;
    }
}