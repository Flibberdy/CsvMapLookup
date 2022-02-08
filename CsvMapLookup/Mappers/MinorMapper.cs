using CsvHelper.Configuration;
using CsvMapLookup.DTO;

namespace CsvMapLookup.Mappers
{
    public sealed class MinorMapper : ClassMap<MinorRural>
    {
        public MinorMapper()
        {
            Map(x => x.StmId).Name("STMID");
            Map(x => x.Id).Name("ID");
            Map(x => x.SiteTypeMinor).Name("SITE_TYPE_MINOR");

        }
    }
}