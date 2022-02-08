using CsvHelper.Configuration;
using CsvMapLookup.DTO;

namespace CsvMapLookup.Mappers
{
    public sealed class CoreMapper : ClassMap<CoreData>
    {
        public CoreMapper()
        {
            Map(x => x.Id).Name("ID");
            Map(x => x.County).Name("COUNTY");
            Map(x => x.Region).Name("REGION");
            Map(x => x.SiteName).Name("SITE_NAME");
            Map(x => x.FieldWorkType).Name("FIELDWORK_TYPE");
            Map(x => x.Area).Name("AREA");
            Map(x => x.Organisation).Name("ORGANISATION");
            Map(x => x.Notes).Name("NOTES");
            
            Map(x => x.XRef).Name("X_REF_MAP");
            Map(x => x.YRef).Name("Y_REF_MAP");
        }
    }
}