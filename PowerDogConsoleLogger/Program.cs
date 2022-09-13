// See https://aka.ms/new-console-template for more information
using CookComputing.XmlRpc;
using PowerDogConsoleLogger;

Console.WriteLine("PowerDog Console Logger");
Console.WriteLine();

while (true)
{
    Proxy myProxy = new Proxy();
    var result = myProxy.getAllCurrentLinearValues("admin");
    var erzeugung = ((XmlRpcStruct)result.Reply[SensorKeys.erzeugung])["Current_Value"];
    var verbrauch = ((XmlRpcStruct)result.Reply[SensorKeys.verbrauchgesamt])["Current_Value"];
    var lieferung = ((XmlRpcStruct)result.Reply[SensorKeys.lieferung])["Current_Value"];
    var bezug = ((XmlRpcStruct)result.Reply[SensorKeys.bezug])["Current_Value"];


    Console.WriteLine($"Zeit: {DateTime.Now.ToLongTimeString()} \t| Erzeugung: {erzeugung} \t| Verbrauch: {verbrauch} \t| Lieferung: {lieferung} \t| Bezug: {bezug}");
    Thread.Sleep(1000);
}

