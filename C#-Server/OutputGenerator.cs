using Microsoft.AspNetCore.Http;

namespace C__Server
{
    internal class OutputGenerator
    {
        internal static ReadOnlySpan<byte> MakeResponse(HttpResponse response)
        {
            return [1, 2, 3, 4];
        }
    }
}
