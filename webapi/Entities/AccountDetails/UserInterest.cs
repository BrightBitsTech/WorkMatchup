﻿namespace webapi.Entities.AccountDetails
{
    public class UserInterest
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int InterestId { get; set; }
        public Interest Interest { get; set; }
    }
}
