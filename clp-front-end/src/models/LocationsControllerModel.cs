namespace clp_front_end.src.models
{
    public partial class LocationsControllerModel
    {
        public partial class Get
        {
            public int id { get; set; }
            public string zone { get; set; }
            public int street { get; set; }
            public int column { get; set; }
            public int level { get; set; }
            public int position { get; set; }
            public int maxCapacity { get; set; }

            public string DisplayText => $"Zona: {zone} | Rua: {street} | Coluna: {column} | Nível: {level} | Pos.: {position} | Peso: {maxCapacity}";
        }
    }
}
