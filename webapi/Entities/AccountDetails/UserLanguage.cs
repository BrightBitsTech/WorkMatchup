using webapi.Entities.Enums;

namespace webapi.Entities.AccountDetails
{
    public class UserLanguage
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public KnowledgeLevel Level { get; set; }
    }
}
