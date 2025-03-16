using System;
using System.Net;


namespace clp_front_end.src.exceptions
{
    public class RestClientException : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public RestClientException(HttpStatusCode statusCode, string message, Exception innerException = null)
            : base(message, innerException)
        {
            StatusCode = statusCode;
        }
    }
}
