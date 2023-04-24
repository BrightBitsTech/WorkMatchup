namespace webapi.Entities
{
    public class SavedJobSearch
    {
        public int Id { get; set; }
        public Account User { get; set; }
        public int UserId { get; set; }
        public string SearchQuery { get; set; }
        public string Filters { get; set; } 
        public DateTime DateCreated { get; set; }
    }
}
