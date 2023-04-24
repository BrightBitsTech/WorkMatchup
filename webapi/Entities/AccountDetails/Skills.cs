using webapi.Entities.Enums;

namespace webapi.Entities.AccountDetails
{
    public class Skills
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SkillsCategory Category { get; set; }
        public List<UserSkill> UserSkills { get; set; }
    }
}
