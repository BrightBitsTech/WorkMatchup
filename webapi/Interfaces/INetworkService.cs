using webapi.Entities;

namespace webapi.Interfaces
{
    public interface INetworkService
    {
        Task<IEnumerable<Network>> GetAllNetworksAsync();
        Task<Network> GetNetworkByIdAsync(int id);
        Task<Network> CreateNetworkAsync(Network newNetwork);
        Task UpdateNetworkAsync(Network updatedNetwork);
        Task DeleteNetworkAsync(int id);
    }
}
