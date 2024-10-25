namespace WorldNest.Models.Oceans
{
    public class Ocean
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public string Location { get; set; }
        public double Depth { get; set; }
        public double Salinity { get; set; }
        public double Temperature { get; set; }
        public string Biodiversity { get; set; }
        public string MajorCurrents { get; set; }
    }
}
