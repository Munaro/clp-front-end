namespace clp_front_end.src.models
{
    public partial class ClpEmulatorEventModel
    {
        public partial class Get
        {            
            public string @typeof { get; set; }
            public string origin { get; set; }
            public string receivedDate { get; set; }
            public float weight { get; set; }
        }
    }
}
