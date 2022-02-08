using CsvHelper.Configuration;

namespace CsvMapLookup.Outputs.Mappers
{
    public sealed class EnrichedMajorRuralMapper : ClassMap<EnrichedMajorRural>
    {
        public EnrichedMajorRuralMapper()
        {
            Map(x => x.StmId).Name("STMID").Index(0);
            Map(x => x.Id).Name("ID").Index(1);
            Map(x => x.SiteTypeMajor).Name("SITE_TYPE_MAJOR").Index(2);
            Map(x => x.MapX).Name("X_REF").Index(3);
            Map(x => x.MapY).Name("Y_REF").Index(4);

        }
    }
}