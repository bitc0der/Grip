using System.Net;
using System.Threading.Tasks;
using Grip.Data;

namespace Grip.Console;

class Program
{
    static async Task Main(string[] args)
    {
        if (args.Length == 0)
        {
            System.Console.WriteLine("IP Endpoint is not specified");
            return;
        }

        var ipEndpoint = args[0];

        if (IPEndPoint.TryParse(ipEndpoint, out var ipEndPoint))
        {
            System.Console.WriteLine($"Connecting to '{ipEndPoint}'...");

            var telemetryData = new TelemetryData();
            var dataReader = new TelemetryDataReader(telemetryData);

            var receiver = new DataReceiver(ipEndPoint, dataReader);

            await receiver.ReceiveAsync();
        }
        else
        {
            System.Console.WriteLine($"IP Endpoint '{ipEndPoint}' is invalid");
        }
    }
}
