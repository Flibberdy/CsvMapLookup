using CsvHelper.Configuration;

namespace CsvMapLookup.Outputs.Mappers
{
    public sealed class EnrichedBurialsMapper : ClassMap<EnrichedBurials>
    {
        public EnrichedBurialsMapper()
        {
            Map(x => x.Id).Name("ID").Index(0);
            Map(x => x.Summary).Name("BURIALS_SUMMARY").Index(1);
            Map(x => x.BurialStartD).Name("BURIAL_START_D").Index(2);
            Map(x => x.BurialEndD).Name("BURIAL_END_D").Index(3);
            Map(x => x.NumberBurials).Name("NUMBER_BURIALS").Index(4);
            Map(x => x.Cremation).Name("CREMATION").Index(5);
            Map(x => x.Inhumation).Name("INHUMATION").Index(6);
            Map(x => x.MapX).Name("X_REF").Index(7);
            Map(x => x.MapY).Name("Y_REF").Index(8);

        }
    }
}