using Entities.DataTransferObjects;
using System.Threading.Tasks;

namespace Contracts.IServices
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUserAsync(UserForAuthenticationDto userForAuth);
        Task<string> CreateTokenAsync();
    }

}
