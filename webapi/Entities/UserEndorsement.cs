﻿namespace webapi.Entities
{
    public class UserEndorsement
    {
        public int Id { get; set; }
        public Account Endorser { get; set; }
        public int EndorserId { get; set; }
        public Account Endorsed { get; set; }
        public int EndorsedId { get; set; }
        public DateTime EndorsementDate { get; set; }
        public Account Skill { get; set; }
        public int SkillId { get; set; }
    }
}
