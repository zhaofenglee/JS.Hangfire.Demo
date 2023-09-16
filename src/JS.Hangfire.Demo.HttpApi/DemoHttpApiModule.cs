using Localization.Resources.AbpUi;
using JS.Hangfire.Demo.Localization;
using Volo.Abp.Account;
using Volo.Abp.AuditLogging;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.LanguageManagement;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Saas.Host;
using Volo.Abp.Localization;
using Volo.Abp.SettingManagement;
using Volo.Abp.TextTemplateManagement;
using Volo.Abp.Gdpr;
using Volo.Abp.OpenIddict;

namespace JS.Hangfire.Demo;

 [DependsOn(
    typeof(DemoApplicationContractsModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule),
    typeof(AbpAuditLoggingHttpApiModule),
    typeof(AbpOpenIddictProHttpApiModule),
    typeof(AbpAccountAdminHttpApiModule),
    typeof(LanguageManagementHttpApiModule),
    typeof(SaasHostHttpApiModule),
    typeof(AbpGdprHttpApiModule),
    typeof(AbpAccountPublicHttpApiModule),
    typeof(TextTemplateManagementHttpApiModule)
    )]
public class DemoHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<DemoResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
