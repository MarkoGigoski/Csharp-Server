namespace C__Server
{
    public readonly record struct Method
    {
        public string Value { get; init; } = string.Empty;

        public Method(string value)
        {
            Value = value.ToUpper();
        }

        public readonly static Method Get = new("GET");
        public readonly static Method Post = new("POST");
        public readonly static Method Put = new("PUT");
        public readonly static Method Delete = new("DELETE");
        public readonly static Method Head = new("HEAD");
        public readonly static Method Options = new("OPTIONS");
        public readonly static Method Trace = new("TRACE");
        public readonly static Method Connect = new("CONNECT");
        public readonly static Method Patch = new("PATCH");

    }
}