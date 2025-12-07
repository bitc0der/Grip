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
            var dataReader = new ConsoleDataReader();

            var receiver = new DataReceiver(ipEndPoint, dataReader);

            await receiver.ReceiveAsync();
        }
    }
}
