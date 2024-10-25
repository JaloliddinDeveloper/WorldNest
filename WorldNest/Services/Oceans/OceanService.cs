using WorldNest.Models.Oceans;

namespace WorldNest.Services.Oceans
{
    public class OceanService
    {
        // Method to retrieve a list of oceans with detailed properties
        public async ValueTask<List<Ocean>> GetOceans()
        {
            return await Task.FromResult(new List<Ocean>
            {
                new Ocean
                {
                    Id = 1,
                    Name = "Tinch okeani",
                    Area = 168723000,
                    Location = "Osiyo/Avstraliya va Amerikalar o'rtasida",
                    Depth = 4280,
                    Salinity = 34.5,
                    Temperature = 24,
                    Biodiversity = "Turli dengiz hayotiga ega, jumladan, marjon riflari, kitlar va akulalar.",
                    MajorCurrents = "Kuroshio oqimi, Kaliforniya oqimi, Gumboldt oqimi"
                },
                new Ocean
                {
                    Id = 2,
                    Name = "Atlantika okeani",
                    Area = 85133000,
                    Location = "Amerikalar va Yevropa/Afrika o'rtasida",
                    Depth = 3646,
                    Salinity = 35.0,
                    Temperature = 26,
                    Biodiversity = "Dengiz hayoti boy, baliqlar, delfinlar va dengiz kaplumbagalari.",
                    MajorCurrents = "Gulf Stream, Shimoliy Atlantika oqimi, Kanariya oqimi"
                },
                new Ocean
                {
                    Id = 3,
                    Name = "Hind okeani",
                    Area = 70300000,
                    Location = "Afrika, Osiyo, Avstraliya o'rtasida",
                    Depth = 3741,
                    Salinity = 34.8,
                    Temperature = 27,
                    Biodiversity = "Marjon riflari va xilma-xil baliq turlari bilan tanilgan.",
                    MajorCurrents = "Agulhas oqimi, Hind okeani oqimi"
                },
                new Ocean
                {
                    Id = 4,
                    Name = "Janubiy okean",
                    Area = 21000000,
                    Location = "Antarktida atrofida",
                    Depth = 3270,
                    Salinity = 34.7,
                    Temperature = -2, // Cold waters
                    Biodiversity = "Unikal turlar, masalan, Imperator pingvini va turli muhrlar.",
                    MajorCurrents = "Antarktika Aylanish oqimi"
                },
                new Ocean
                {
                    Id = 5,
                    Name = "Arktika okeani",
                    Area = 15100000,
                    Location = "Arktika mintaqasida",
                    Depth = 1200,
                    Salinity = 30.0,
                    Temperature = -1.8, // Near freezing
                    Biodiversity = "Sovuq harorat tufayli cheklangan biologik xilma-xillik; qutb ayiq va muhrlarni o'z ichiga oladi.",
                    MajorCurrents = "Transpolar Drift, Beaufort Gyre"
                }
            });
        }

        // Method to retrieve an ocean by its ID
        public async ValueTask<Ocean> GetOceanById(int id)
        {
            var oceans = await GetOceans();
            return oceans.FirstOrDefault(o => o.Id == id);
        }
    }
}
