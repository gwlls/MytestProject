using System.Threading.Tasks;
using Abp.Application.Services;
using MyFirstAbpCore.Authorization.Accounts.Dto;

namespace MyFirstAbpCore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
