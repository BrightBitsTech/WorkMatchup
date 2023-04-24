using Microsoft.AspNetCore.Mvc;
using webapi.Entities;
using webapi.Interfaces;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[network]")]
    public class NetworkController : BaseController
    {
        private readonly INetworkService _networkService;
        public NetworkController(INetworkService networkService)
        {
            _networkService = networkService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllNetworks()
        {
            return Ok(await _networkService.GetAllNetworksAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNetworkById(int id)
        {
            var network = await _networkService.GetNetworkByIdAsync(id);
            if (network == null) return NotFound();
            return Ok(network);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNetwork(Network newNetwork)
        {
            await _networkService.CreateNetworkAsync(newNetwork);
            return CreatedAtAction(nameof(GetNetworkById), new { id = newNetwork.Id }, newNetwork);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNetwork(int id, Network updatedNetwork)
        {
            if (id != updatedNetwork.Id) return BadRequest();
            await _networkService.UpdateNetworkAsync(updatedNetwork);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNetwork(int id)
        {
            await _networkService.DeleteNetworkAsync(id);
            return NoContent();
        }
    }
}
