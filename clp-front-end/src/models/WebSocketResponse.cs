namespace clp_front_end.src.models
{
    public class WebSocketResponse<T>
    {
        public string Event { get; set; }
        public T Data { get; set; }
    }
}
