namespace clp_front_end.src.models
{
    public partial class ContainersControllerModel
    {
        public partial class Create
        {
            public string origin { get; set; }
            public string receivedDate { get; set; }
            public float weight { get; set; }
            public int statusId { get; set; }
            public int locationId { get; set; }
            public string uuid { get; set; }
            public string uniqueIdentifier { get; set; }
        }

        public partial class Update
        {
            public int containerId { get; set; }
            public int statusId { get; set; }
        }

        public partial class Get
        {
            public int internalId { get; set; }
            public string containerId { get; set; }
            public string receivedDate { get; set; }
            public float containerWeight { get; set; }
            public string status { get; set; }
            public string storedZone { get; set; }
            public int storedStreet { get; set; }
            public int storedColumn { get; set; }
            public int storedPosition { get; set; }
        }
        public partial class GetDataStatus
        {
            public int id { get; set; }
            public string description { get; set; }
        }
        public partial class GetData
        {
            public GetDataStatus[] status { get; set; }
        }
    }
}
