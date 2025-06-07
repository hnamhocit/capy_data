using System;

namespace Data.Constants
{
    static class SocketConstants
    {
        public const string VpsIp = "38.240.48.202";
        public const string DevIp = "localhost";
        public const int Port = 3000;
        public static readonly Uri BaseUri = new Uri("http://" + DevIp + ":" + Port);
    }
}
