﻿using Neat.WindowsPhone7.Wrapper.Web.Abstract;

namespace Neat.WindowsPhone7.Service.Rest.Client
{
    public class HttpWebProxyRequest
    {
        public HttpWebRequestBase HttpWebRequestBase { get; set; }
        public ProcessRequestStream ProcessRequestStream { get; set; }
        public ProcessResponseStream ProcessResponseStream { get; set; }
        public ResponseCallback ResponseCallback { get; set; }
        public HttpMethod Method { get; set; }
        public byte[] RequestBytes { get; set; }
    }
}