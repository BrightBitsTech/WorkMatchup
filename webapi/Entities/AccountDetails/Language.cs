﻿using webapi.Entities.Enums;

namespace webapi.Entities.AccountDetails
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UserLanguage> UserLanguages { get; set; }
    }
}
