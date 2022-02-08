using CsvMapLookup.DTO;

namespace CsvMapLookup.Outputs
{
    public class EnrichedMinorRural : MinorRural

    {
        public string MapX { get; set; }
        
        public string MapY { get; set; }
    }
}