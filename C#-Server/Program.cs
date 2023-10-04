using System.Net;
using System.Net.Sockets;
using System.Text;
using C__Server;

var address = IPAddress.Any;
var port = 666; //Why not :)

TcpListener listener = new TcpListener(address, port);
listener.Start();

while (true)
{
    //Whait for request
    Console.WriteLine("Waiting for the tcp client");
    var client = listener.AcceptTcpClient();
    Console.WriteLine($"Accepted tcp client");
    using var stream = client.GetStream();
    byte[] buffer = new byte[8192];
    Span<byte> bytes = new(buffer);
    var byteCount = stream.Read(bytes); //Why do we use this: stream.Read(bytes), and then decode them the as the same and not the read version byteCount, is it only to see them as example?
    Console.WriteLine(byteCount);
    var requestString = Encoding.UTF8.GetString(bytes);

    //Process the request
    var request = RequestProcessor.ProcessRequest(requestString);
    var response = ActualProcessor.Process(request);
    var output = OutputGenerator.MakeResponse(response);
    stream.Write(output);

}