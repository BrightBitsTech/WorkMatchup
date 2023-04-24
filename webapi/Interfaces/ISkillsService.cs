using webapi.Entities.AccountDetails;

namespace webapi.Interfaces
{
    public interface ISkillsService
    {
        Task<IEnumerable<Skills>> GetAllSkillsAsync();
        Task<Skills> GetSkillByIdAsync(int id);
        Task<Skills> CreateSkillAsync(Skills newSkill);
        Task UpdateSkillAsync(Skills updatedSkill);
        Task DeleteSkillAsync(int id);
    }
}
