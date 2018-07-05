using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyFirstAbpCore.Controllers
{
    public abstract class MyFirstAbpCoreControllerBase: AbpController
    {
        protected MyFirstAbpCoreControllerBase()
        {
            LocalizationSourceName = MyFirstAbpCoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
