﻿namespace webapi.Entities.AccountDetails
{
    public class UserSkill
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int SkillsId { get; set; }
        public Skills Skills { get; set; }
    }
}
