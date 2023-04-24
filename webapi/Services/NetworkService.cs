using Microsoft.EntityFrameworkCore;
using webapi.Entities;
using webapi.Helpers;
using webapi.Interfaces;

namespace webapi.Services
{
    public class NetworkService : INetworkService
    {
        private readonly DataContext _context;
        public NetworkService(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Network>> GetAllNetworksAsync()
        {
            return await _context.Networks.ToListAsync();
        }

        public async Task<Network> GetNetworkByIdAsync(int id)
        {
            return await _context.Networks.FindAsync(id);
        }

        public async Task<Network> CreateNetworkAsync(Network newNetwork)
        {
            _context.Networks.Add(newNetwork);
            await _context.SaveChangesAsync();
            return newNetwork;
        }

        public async Task UpdateNetworkAsync(Network updatedNetwork)
        {
            _context.Entry(updatedNetwork).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteNetworkAsync(int id)
        {
            var network = await _context.Networks.FindAsync(id);
            _context.Networks.Remove(network);
            await _context.SaveChangesAsync();
        }
    }
}
