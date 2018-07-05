using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyFirstAbpCore.MultiTenancy.Dto;

namespace MyFirstAbpCore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
