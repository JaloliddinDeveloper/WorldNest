using WorldNest.Models.Countries;

namespace WorldNest.Services.Countries
{
    public class CountryService
    {
        public async ValueTask<List<Country>> GetCountries()
        {
            return await Task.FromResult(new List<Country>
            {
                new Country { Id = 1, Name = "O‘zbekiston", Capital = "Toshkent", Population = 34232050, Area = 448978, Language = "O‘zbek", Currency = "So‘m" },
                new Country { Id = 2, Name = "Amerika Qo‘shma Shtatlari", Capital = "Vashington, D.C.", Population = 331002651, Area = 9833520, Language = "Ingliz tili", Currency = "AQSh dollari" },
                new Country { Id = 3, Name = "Fransiya", Capital = "Parij", Population = 65273511, Area = 551695, Language = "Fransuz tili", Currency = "Yevro" },
                new Country { Id = 4, Name = "Germaniya", Capital = "Berlin", Population = 83783942, Area = 357022, Language = "Nemis tili", Currency = "Yevro" },
                new Country { Id = 5, Name = "Birlashgan Qirollik", Capital = "London", Population = 67886011, Area = 243610, Language = "Ingliz tili", Currency = "Funt sterling" },
                new Country { Id = 6, Name = "Italiya", Capital = "Rim", Population = 60244639, Area = 301340, Language = "Italya tili", Currency = "Yevro" },
                new Country { Id = 7, Name = "Ispaniya", Capital = "Madrid", Population = 46754778, Area = 505992, Language = "Ispan tili", Currency = "Yevro" },
                new Country { Id = 8, Name = "Xitoy", Capital = "Pekin", Population = 1439323776, Area = 9596961, Language = "Mandarin", Currency = "Yuan" },
                new Country { Id = 9, Name = "Hindiston", Capital = "Yangi Dehli", Population = 1380004385, Area = 3287263, Language = "Hind tili", Currency = "Hind rupiyasi" },
                new Country { Id = 10, Name = "Braziliya", Capital = "Brazilia", Population = 212559417, Area = 8515767, Language = "Portugaliya tili", Currency = "Braziliya reali" },
                new Country { Id = 11, Name = "Rossiya", Capital = "Moskva", Population = 145912025, Area = 17098242, Language = "Rus tili", Currency = "Rus rubli" },
                new Country { Id = 12, Name = "Kanada", Capital = "Ottava", Population = 37742154, Area = 9984670, Language = "Ingliz tili, Fransuz tili", Currency = "Kanada dollari" },
                new Country { Id = 13, Name = "Avstraliya", Capital = "Kanberra", Population = 25499884, Area = 7692024, Language = "Ingliz tili", Currency = "Avstraliya dollari" },
                new Country { Id = 14, Name = "Meksika", Capital = "Mexiko", Population = 128932753, Area = 1964375, Language = "Ispan tili", Currency = "Meksika pesosi" },
                new Country { Id = 15, Name = "Yaponiya", Capital = "Tokio", Population = 126476461, Area = 377975, Language = "Yapon tili", Currency = "Yen" },
                new Country { Id = 16, Name = "Janubiy Koreya", Capital = "Seul", Population = 51269185, Area = 100032, Language = "Koreys tili", Currency = "Von" },
                new Country { Id = 17, Name = "Turkiya", Capital = "Anqara", Population = 84339067, Area = 783356, Language = "Turk tili", Currency = "Turk lirasi" },
                new Country { Id = 18, Name = "Argentina", Capital = "Buenos-Ayres", Population = 45195777, Area = 2780400, Language = "Ispan tili", Currency = "Argentina pesosi" },
                new Country { Id = 19, Name = "Misr", Capital = "Qohira", Population = 102334155, Area = 1002450, Language = "Arab tili", Currency = "Misr funti" },
                new Country { Id = 20, Name = "Janubiy Afrika", Capital = "Pretoria (ma’muriy)", Population = 59308690, Area = 1219090, Language = "Zulu, Xhosa, Afrikans, Ingliz tili", Currency = "Janubiy Afrika randi" },
                new Country { Id = 21, Name = "Saudiya Arabistoni", Capital = "Ar-Riyod", Population = 34813867, Area = 2149690, Language = "Arab tili", Currency = "Saudi riyoli" },
                new Country { Id = 22, Name = "Eron", Capital = "Tehron", Population = 83992949, Area = 1648195, Language = "Fors tili", Currency = "Eron riali" },
                new Country { Id = 23, Name = "Nigeriya", Capital = "Abuja", Population = 206139589, Area = 923768, Language = "Ingliz tili", Currency = "Naira" },
                new Country { Id = 24, Name = "Kolumbiya", Capital = "Bogota", Population = 50882891, Area = 1141748, Language = "Ispan tili", Currency = "Kolumbiya pesosi" },
                new Country { Id = 25, Name = "Tailand", Capital = "Bangkok", Population = 69799978, Area = 513120, Language = "Tay tili", Currency = "Bat" },
                new Country { Id = 26, Name = "Vyetnam", Capital = "Xanoy", Population = 97338579, Area = 331212, Language = "Vyetnam tili", Currency = "Dong" },
                new Country { Id = 27, Name = "Filippin", Capital = "Manila", Population = 109581078, Area = 300000, Language = "Filipino, Ingliz tili", Currency = "Filippin pesosi" },
                new Country { Id = 28, Name = "Malayziya", Capital = "Kuala-Lumpur", Population = 32365999, Area = 330803, Language = "Malay tili", Currency = "Malayziya ringgiti" },
                new Country { Id = 29, Name = "Pokiston", Capital = "Islomobod", Population = 225199937, Area = 881913, Language = "Urdu, Ingliz tili", Currency = "Pokiston rupiyasi" },
                new Country { Id = 30, Name = "Bangladesh", Capital = "Dakka", Population = 166303498, Area = 147570, Language = "Bengal tili", Currency = "Bangladesh takasi" },
            });
        }

        public async ValueTask<Country> GetCountryById(int id)
        {
            var countries = await GetCountries();
            return countries.FirstOrDefault(c => c.Id == id);
        }
    }
}
