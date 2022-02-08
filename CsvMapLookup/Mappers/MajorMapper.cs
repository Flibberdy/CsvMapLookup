using CsvHelper.Configuration;
using CsvMapLookup.DTO;

namespace CsvMapLookup.Mappers
{
    public sealed class MajorMapper : ClassMap<MajorRural>
    {
        public MajorMapper()
        {
            Map(x => x.StmId).Name("STMID");
            Map(x => x.Id).Name("ID");
            Map(x => x.SiteTypeMajor).Name("SITE_TYPE_MAJOR");

        }
    }
}