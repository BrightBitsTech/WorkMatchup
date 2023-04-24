using System.Text.Json.Serialization;

namespace webapi.Entities
{
    public class CompanyProfile
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Industry { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; } // Change this to byte[] if storing the logo as a file
        public string Website { get; set; }
        public List<JobOffer> JobOffers { get; set; }
    }
}
