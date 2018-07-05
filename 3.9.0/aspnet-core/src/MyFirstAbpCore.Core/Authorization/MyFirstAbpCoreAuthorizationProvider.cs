using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace MyFirstAbpCore.Authorization
{
    public class MyFirstAbpCoreAuthorizationProvider : AuthorizationProvider
    {//在使用验证权限前，我们需要为每一个操作定义唯一的权限
        public override void SetPermissions(IPermissionDefinitionContext context)//IPermissionDefinitionContext 有方法去获取和创建权限
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, MyFirstAbpCoreConsts.LocalizationSourceName);
        }
    }
}
