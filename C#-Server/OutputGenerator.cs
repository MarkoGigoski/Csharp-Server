using Microsoft.AspNetCore.Http;

namespace C__Server
{
    internal class OutputGenerator
    {
        internal static ReadOnlySpan<byte> MakeResponse(HttpResponse response)
        {
            return [1, 2, 3, 4]; //why do we need to upgrate C#-Server with preview, and what does the preview do?, and why do we hard code this? how is it related to the respons?
        }
    }
}
