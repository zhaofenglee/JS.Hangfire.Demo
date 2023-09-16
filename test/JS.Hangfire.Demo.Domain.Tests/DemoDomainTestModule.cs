using JS.Hangfire.Demo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace JS.Hangfire.Demo;

[DependsOn(
    typeof(DemoEntityFrameworkCoreTestModule)
    )]
public class DemoDomainTestModule : AbpModule
{

}
