namespace clp_front_end.src.models
{
    public partial class MovementsControllerModel
    {
        public partial class Get
        {
            public string movedAt { get; set; }
            public int haveFrom { get; set; }
            public object fromZone { get; set; }
            public object fromStreet { get; set; }
            public object fromColumn { get; set; }
            public object fromPosition { get; set; }
            public int haveTo { get; set; }
            public string toZone { get; set; }
            public int toStreet { get; set; }
            public int toColumn { get; set; }
            public int toPosition { get; set; }
        }
        public partial class ChangePosition
        {
            public int containerId { get; set; }
            public int toLocationId { get; set; }
        }
    }
}
