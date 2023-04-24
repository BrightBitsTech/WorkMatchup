using Microsoft.VisualBasic;
using webapi.Entities.AccountDetails;
using webapi.Entities.Enums;

namespace webapi.Entities
{
    public class JobOffer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Industry { get; set; }
        public string JobTitle { get; set; }
        public string Location { get; set; }
        public string Responsibilities { get; set; }
        public int RequiredExperience { get; set; }
        public string RequiredEducation { get; set; }
        public List<Language> RequiredLanguages { get; set; }
        public List<Skills> RequiredSkills { get; set; }
        public Decimal OfferedSalary { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public string Description { get; set; }
        public string RecruitmentInformation { get; set; }
    }
}
