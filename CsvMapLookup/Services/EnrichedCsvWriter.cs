using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace CsvMapLookup.Services
{
    public class EnrichedCsvWriter<TDataMapper, TInput> where TDataMapper : ClassMap
    {
        public void Write(string path, IEnumerable<TInput> enrichedMinorRecords )
        {
            using var writer = new StreamWriter(path);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.Context.RegisterClassMap<TDataMapper>();
            csv.WriteRecords(enrichedMinorRecords);
        }
    }
}