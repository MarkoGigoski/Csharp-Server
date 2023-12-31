﻿using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;

namespace C__Server
{
    public static class RequestProcessor
    {
        private static readonly Regex requestLineRegex = new("^([A-Z]+) /([^ ]+) HTTP/1.1$", RegexOptions.Multiline);

        public static bool IsRequestValid(string request)
        {
            var requestLines = request.Split(Environment.NewLine);// Does Environment.NewLine splits the string word by word and place them in array?
            if (requestLines.Length == 0)
            {
                return false;
            }

            var match = requestLineRegex.Match(requestLines[0]); //If the method its not the first chek? and we extract it down below as [1], then what is the first match chek up?
            if (!match.Success)
            {
                return false;
            }

            var method = match.Groups[1].Value;
            var uri = match.Groups[2].Value;
            Console.WriteLine($"{method} {uri}");

            return true;
        }

        internal static HttpRequest ProcessRequest(string request)
        {
            var isValidRequest = IsRequestValid(request);
            Console.WriteLine($"This request is {(isValidRequest ? "valid" : "invalid")}");
            return new HttpRequest();
        }
    }
}
