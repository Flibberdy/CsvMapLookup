using CsvHelper.Configuration;
using CsvMapLookup.DTO;

namespace CsvMapLookup.Mappers
{
    public sealed class BurialsMapper : ClassMap<Burials>
    {
        public BurialsMapper()
        {
            Map(x => x.Id).Name("ID");
            Map(x => x.Summary).Name("BURIALS_SUMMARY");
            Map(x => x.BurialStartD).Name("BURIAL_START_D");
            Map(x => x.BurialEndD).Name("BURIAL_END_D");
            Map(x => x.NumberBurials).Name("NUMBER_BURIALS");
            Map(x => x.Cremation).Name("CREMATION");
            Map(x => x.Inhumation).Name("INHUMATION");

        }
    }
}