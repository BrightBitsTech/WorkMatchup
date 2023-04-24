using webapi.Entities.AccountDetails;
using webapi.Entities.Enums;

namespace webapi.Models.Accounts
{
    public class AccountResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? City { get; set; }
        public int? Experience { get; set; }
        public string? Education { get; set; }
        public List<Language>? Languages { get; set; }
        public List<Skills>? Skills { get; set; }
        public List<Interest>? Interests { get; set; }
        public Decimal? ExpectedSalary { get; set; }
        public List<EmploymentType>? EmploymentType { get; set; }
        public byte[]? Cv { get; set; }
        public byte[]? Photo { get; set; }

        public string Role { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool IsVerified { get; set; }
    }
}
