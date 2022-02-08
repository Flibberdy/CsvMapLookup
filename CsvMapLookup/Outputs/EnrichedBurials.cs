using CsvMapLookup.DTO;

namespace CsvMapLookup.Outputs
{
    public class EnrichedBurials : Burials

    {
        public string MapX { get; set; }
        
        public string MapY { get; set; }
    }
}