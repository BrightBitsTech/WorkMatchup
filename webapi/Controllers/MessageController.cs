using Microsoft.AspNetCore.Mvc;
using webapi.Entities;
using webapi.Interfaces;

namespace webapi.Controllers
{
    public class MessageController : BaseController
    {
        private readonly IMessageService _messageService;
        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMessages()
        {
            return Ok(await _messageService.GetAllMessagesAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMessageById(int id)
        {
            var message = await _messageService.GetMessageByIdAsync(id);
            if (message == null) return NotFound();
            return Ok(message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(Message newMessage)
        {
            await _messageService.CreateMessageAsync(newMessage);
            return CreatedAtAction(nameof(GetMessageById), new { id = newMessage.Id }, newMessage);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMessage(int id, Message updatedMessage)
        {
            if (id != updatedMessage.Id) return BadRequest();
            await _messageService.UpdateMessageAsync(updatedMessage);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            await _messageService.DeleteMessageAsync(id);
            return NoContent();
        }
    }
}
