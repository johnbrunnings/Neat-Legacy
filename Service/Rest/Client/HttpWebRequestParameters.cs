﻿using System;
using System.Text;

namespace Neat.Service.Rest.Client
{
    public class HttpWebRequestParameters
    {
        public Uri RequestUri { get; set; }
        public HttpMethod Method { get; set; }
        public byte[] RequestBytes { get; set; }
        public string RequestData { get; set; }
        public Encoding Encoding { get; set; }
        public long ContentLength { get; set; }
        public string ContentType { get; set; }
        public int ReadWriteTimeout { get; set; }
        public int Timeout { get; set; }
        public string TransferEncoding { get; set; }
        public ProcessRequestStream ProcessRequestStream { get; set; }
        public ProcessResponseStream ProcessResponseStream { get; set; }
        public ResponseCallback ResponseCallback { get; set; }
    }
}