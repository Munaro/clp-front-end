using System.Net;

namespace clp_front_end.src.models
{
    public class RestClientResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }
}
