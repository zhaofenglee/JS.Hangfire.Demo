using JS.Hangfire.Demo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace JS.Hangfire.Demo.Web.Pages;

public abstract class DemoPageModel : AbpPageModel
{
    protected DemoPageModel()
    {
        LocalizationResourceType = typeof(DemoResource);
    }
}
