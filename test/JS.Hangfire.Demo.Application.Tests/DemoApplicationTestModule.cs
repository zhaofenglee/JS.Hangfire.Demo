using Volo.Abp.Modularity;

namespace JS.Hangfire.Demo;

[DependsOn(
    typeof(DemoApplicationModule),
    typeof(DemoDomainTestModule)
    )]
public class DemoApplicationTestModule : AbpModule
{

}
