using Microsoft.AspNetCore.Mvc;
using webapi.Entities.AccountDetails;
using webapi.Interfaces;

namespace webapi.Controllers
{
    [Route("skills/[controller]")]
    [ApiController]
    public class SkillsController : BaseController
    {
        private readonly ISkillsService _skillsService;
        public SkillsController(ISkillsService skillsService)
        {
            _skillsService = skillsService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSkills()
        {
            return Ok(await _skillsService.GetAllSkillsAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSkillById(int id)
        {
            var skill = await _skillsService.GetSkillByIdAsync(id);
            if (skill == null) return NotFound();
            return Ok(skill);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSkill(Skills newSkill)
        {
            await _skillsService.CreateSkillAsync(newSkill);
            return CreatedAtAction(nameof(GetSkillById), new { id = newSkill.Id }, newSkill);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSkill(int id, Skills updatedSkill)
        {
            if (id != updatedSkill.Id) return BadRequest();
            await _skillsService.UpdateSkillAsync(updatedSkill);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkill(int id)
        {
            await _skillsService.DeleteSkillAsync(id);
            return NoContent();
        }
    }
}
