// See https://aka.ms/new-console-template for more information

using CsvMapLookup.DTO;
using CsvMapLookup.Mappers;
using CsvMapLookup.Outputs;
using CsvMapLookup.Outputs.Mappers;
using CsvMapLookup.Services;

var coreRecords = new EnrichedCsvReader<CoreMapper, CoreData>().Read("C:\\temp\\geo\\rrs_core_data.csv");
var minorRecords = new EnrichedCsvReader<MinorMapper, MinorRural>().Read("C:\\temp\\geo\\minorrural.csv");
var majorRecords = new EnrichedCsvReader<MajorMapper, MajorRural>().Read("C:\\temp\\geo\\majorrural.csv");
var burialRecords = new EnrichedCsvReader<BurialsMapper, Burials>().Read("C:\\temp\\geo\\burials.csv");

var enrichedMinorRecords = from record in coreRecords
join minor in minorRecords 
    on record.Id equals minor.Id
    select new EnrichedMinorRural
    {
        Id = minor.Id,
        StmId = minor.StmId,
        SiteTypeMinor = minor.SiteTypeMinor,
        MapX = record.XRef,
        MapY = record.YRef
    };

var enrichedMajorRecords = from record in coreRecords
    join major in majorRecords 
        on record.Id equals major.Id
    select new EnrichedMajorRural
    {
        Id = major.Id,
        StmId = major.StmId,
        SiteTypeMajor = major.SiteTypeMajor,
        MapX = record.XRef,
        MapY = record.YRef
    };


var enrichedBurialsRecords = from record in coreRecords
    join burial in burialRecords 
        on record.Id equals burial.Id
    select new EnrichedBurials
    {
        Id = burial.Id,
        Summary = burial.Summary,
        BurialStartD = burial.BurialStartD,
        BurialEndD = burial.BurialEndD,
        NumberBurials = burial.NumberBurials,
        Cremation = burial.Cremation,
        Inhumation = burial.Inhumation,
        MapX = record.XRef,
        MapY = record.YRef
    };    

new EnrichedCsvWriter<EnrichedMinorRuralMapper, EnrichedMinorRural>().Write("C:\\temp\\geo\\enrichedMinorRural.csv", enrichedMinorRecords);
new EnrichedCsvWriter<EnrichedMajorRuralMapper, EnrichedMajorRural>().Write("C:\\temp\\geo\\enrichedMajorRural.csv", enrichedMajorRecords);
new EnrichedCsvWriter<EnrichedBurialsMapper, EnrichedBurials>().Write("C:\\temp\\geo\\enrichedBurials.csv", enrichedBurialsRecords);


    