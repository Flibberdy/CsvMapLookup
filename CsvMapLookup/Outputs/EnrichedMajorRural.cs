using CsvMapLookup.DTO;

namespace CsvMapLookup.Outputs
{
    public class EnrichedMajorRural : MajorRural

    {
        public string MapX { get; set; }
        
        public string MapY { get; set; }
    }
}