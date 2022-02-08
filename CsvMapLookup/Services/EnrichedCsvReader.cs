using System.Globalization;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace CsvMapLookup.Services
{
    public class EnrichedCsvReader<TDataMapper, TOutput> where TDataMapper : ClassMap
    {
        public List<TOutput> Read(string path)
        {
            using var reader = new StreamReader(path, Encoding.Default);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Context.RegisterClassMap<TDataMapper>();
            var records = csv.GetRecords<TOutput>().ToList();
            return records;
        }
    }
}