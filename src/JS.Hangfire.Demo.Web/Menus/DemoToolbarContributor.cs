﻿using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using JS.Hangfire.Demo.Web.Components.Toolbar.LoginLink;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.Users;

namespace JS.Hangfire.Demo.Web.Menus;

public class DemoToolbarContributor : IToolbarContributor
{
    public virtual Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
    {
        if (context.Toolbar.Name != StandardToolbars.Main)
        {
            return Task.CompletedTask;
        }

        if (!context.ServiceProvider.GetRequiredService<ICurrentUser>().IsAuthenticated)
        {
            context.Toolbar.Items.Add(new ToolbarItem(typeof(LoginLinkViewComponent)));
        }

        return Task.CompletedTask;
    }
}
