// Type: Nancy.Request
// Assembly: Nancy, Version=0.11.0.0, Culture=neutral, PublicKeyToken=null
// Assembly location: C:\Code\YaBigNancy\packages\Nancy.0.11.0\lib\net40\Nancy.dll

using Nancy.IO;
using Nancy.Session;
using System;
using System.Collections.Generic;

namespace Nancy
{
    public class Request : IDisposable
    {
        public Request(string method, string path, string scheme);
        public Request(string method, string path, IDictionary<string, IEnumerable<string>> headers, RequestStream body, string scheme, string query = null, string ip = null);
        public Request(string method, Url url, RequestStream body = null, IDictionary<string, IEnumerable<string>> headers = null, string ip = null);
        public string UserHostAddress { get; }
        public string Method { get; }
        public Url Url { get; }
        public string Path { get; }
        public dynamic Query { get; set; }
        public RequestStream Body { get; }
        public IDictionary<string, string> Cookies { get; }
        public ISession Session { get; set; }
        public IEnumerable<HttpFile> Files { get; }
        public dynamic Form { get; }
        public RequestHeaders Headers { get; }

        #region IDisposable Members

        public void Dispose();

        #endregion
    }
}
