using Microsoft.EntityFrameworkCore;
using webapi.Entities.AccountDetails;
using webapi.Helpers;
using webapi.Interfaces;

namespace webapi.Services
{
    public class SkillsService : ISkillsService
    {
        private readonly DataContext _context;
        public SkillsService(DataContext context)
        {
            _context = context;
        }
        public async Task<Skills> CreateSkillAsync(Skills newSkill)
        {
            _context.Skills.Add(newSkill);
            await _context.SaveChangesAsync();
            return newSkill;
        }

        public async Task DeleteSkillAsync(int id)
        {
            var skill = await _context.Skills.FindAsync(id);
            _context.Skills.Remove(skill);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Skills>> GetAllSkillsAsync()
        {
            return await _context.Skills.ToListAsync();
        }

        public async Task<Skills> GetSkillByIdAsync(int id)
        {
            return await _context.Skills.FindAsync(id);
        }

        public async Task UpdateSkillAsync(Skills updatedSkill)
        {
            _context.Entry(updatedSkill).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
