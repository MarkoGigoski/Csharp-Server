using Microsoft.AspNetCore.Http;
using RestSharp;

namespace C__Server
{
    internal class ActualProcessor
    {
        internal static HttpResponse Process(HttpRequest request)
        {
            if (request.Method.Equals(Method.Get))
            {

            }
            return null;
        }
    }
}
