namespace webapi.Entities
{
    public class UserEndorsement
    {
        public int Id { get; set; }
        public Account Endorser { get; set; }
        public int EndorserId { get; set; }
        public Account EndorsedUser { get; set; }
        public int EndorsedUserId { get; set; }
        public Account Skill { get; set; }
        public int SkillId { get; set; }
        public DateTime DateEndorsed { get; set; }
    }
}
